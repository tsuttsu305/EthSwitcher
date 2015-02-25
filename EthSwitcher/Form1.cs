﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthSwitcher {
    public partial class Form1 : Form {

        private NetworkAdapterController _controller;
        private List<String> _adapters;
        private bool _onlyConnectedAdapter = true;

        public Form1() {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            _controller = new NetworkAdapterController();

            _adapters = _controller.GetConnectedAdapters();
            nicList.DataSource = _adapters;

            nicList.DropDownStyle = ComboBoxStyle.DropDownList;

            settingList.DataSource = ConfigList.GetInstance().GetNames();
            settingList.DisplayMember = "Name";

            isConnectedAdapterOnly.Checked = _onlyConnectedAdapter;
        }

        private void nicList_SelectedIndexChanged(object sender, EventArgs e) {
            AdapterStatusViewUpdate();
        }

        private void setNowBtn_Click(object sender, EventArgs e) {
            String nic = _adapters[nicList.SelectedIndex];
            try {
                IPAddress address;
                if (NetworkUtil.IsIPAddressFomat(ipaddrBox.Text, true)) {
                    if (NetworkUtil.IsIPAddressFomat(maskBox.Text, true)) {
                        if (NetworkUtil.IsIPAddressFomat(gatewayBox.Text, true)) {
                            if (NetworkUtil.IsIPAddressFomat(dns1Box.Text, true)) {
                                if (NetworkUtil.IsIPAddressFomat(dns2Box.Text, true)) {
                                    _controller.SetDnsServers(nic, new[] { dns1Box.Text, dns2Box.Text });
                                    _controller.SetIpAddress(nic, ipaddrBox.Text, maskBox.Text);
                                    _controller.SetGateway(nic, gatewayBox.Text);

                                    AdapterStatusViewUpdate();
                                } else {
                                    MessageBox.Show("DNS2が不正です。");
                                }
                            } else {
                                MessageBox.Show("DNS1が不正です。");
                            }
                        } else {
                            MessageBox.Show("Gatewayが不正です。");
                        }
                    } else {
                        MessageBox.Show("SubnetMaskが不正です。");
                    }
                } else {
                    MessageBox.Show("IPアドレスが不正です。");
                }
            } catch (Exception) {
                MessageBox.Show("未知のエラーが発生しました");
            }
        }

        private void settingList_SelectedIndexChanged(object sender, EventArgs e) {
            ConfigList.Config data = ConfigList.GetInstance().GetItem(settingList.SelectedIndex);

            if (data == null)return;

            ipaddrBox.Text = data.IpAddress;
            maskBox.Text = data.Subnet;
            gatewayBox.Text = data.Gateway;
            dns1Box.Text = data.Dns1;
            dns2Box.Text = data.Dns2;
            nameBox.Text = data.Name;
        }

        private void addNowBtn_Click(object sender, EventArgs e) {
            NameDialog nd = new NameDialog();
            if (nd.ShowDialog(this) == DialogResult.OK) {
                ConfigList.GetInstance().Add(nd.Name, ipaddrView.Text, maskView.Text, gatewayView.Text, dns1view.Text, dns2View.Text);
            }
            nd.Dispose();

            settingList.DataSource = ConfigList.GetInstance().GetNames();
        }

        private void delBtn_Click(object sender, EventArgs e) {
            ConfigList.Config data = ConfigList.GetInstance().GetItem(settingList.SelectedIndex);

            if (data == null)return;

            ConfigList.GetInstance().Remove(data);

            settingList.DataSource = ConfigList.GetInstance().GetNames();
        }

        private void addListBtn_Click(object sender, EventArgs e) {
            ConfigList.Config data = new ConfigList.Config();

            data.Name = nameBox.Text;
            data.IpAddress = ipaddrBox.Text;
            data.Subnet = maskBox.Text;
            data.Gateway = gatewayBox.Text;
            data.Dns1 = dns1Box.Text;
            data.Dns2 = dns2Box.Text;

            ConfigList.GetInstance().Add(data);
            settingList.DataSource = ConfigList.GetInstance().GetNames();
        }

        private void isConnectedAdapterOnly_Click(object sender, EventArgs e) {
            _onlyConnectedAdapter = isConnectedAdapterOnly.Checked;

            if (_onlyConnectedAdapter) {
                _adapters = _controller.GetConnectedAdapters();
                nicList.DataSource = _adapters;
            } else {
                _adapters = _controller.GetAdapters();
                nicList.DataSource = _adapters;
            }
        }

        private void box_Click(object sender, EventArgs e) {
            var box = sender as TextBox;
            if (box != null) {
                box.SelectAll();
            }
        }

        public void AdapterStatusViewUpdate() {
            String nic = _adapters[nicList.SelectedIndex];
            ipaddrView.Text = _controller.GetIPAddress(nic);
            maskView.Text = _controller.GetSubnetMask(nic);
            gatewayView.Text = _controller.GetGateway(nic);
            String[] dns = _controller.GetDnsServers(nic);
            dns1view.Text = dns[0];
            dns2View.Text = dns[1];
            macView.Text = _controller.GetMacAddress(nic);
        }
    }
}
