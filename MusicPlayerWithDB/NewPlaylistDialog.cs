using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerWithDB {
    public partial class NewPlaylistDialog : Form {
        public NewPlaylistDialog() {
            InitializeComponent();
        }
        public string SendText {
            get { return textBox1.Text; }
        }

        private void Confirm_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void Cancel_bt_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
