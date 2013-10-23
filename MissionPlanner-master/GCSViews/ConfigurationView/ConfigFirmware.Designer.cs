﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Net;

namespace MissionPlanner.GCSViews
{
    partial class ConfigFirmware : MyUserControl
    {
        
                /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        
        private Controls.ImageLabel pictureBoxAPM;
        private Controls.ImageLabel pictureBoxQuad;
        private Controls.ImageLabel pictureBoxHexa;
        private Controls.ImageLabel pictureBoxTri;
        private Controls.ImageLabel pictureBoxY6;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label2;
        private Controls.ImageLabel pictureBoxHeli;
        private Controls.MyButton BUT_setup;
        private PictureBox pictureBoxHilimage;
        private PictureBox pictureBoxAPHil;
        private PictureBox pictureBoxACHil;
        private PictureBox pictureBoxACHHil;
        private Controls.ImageLabel pictureBoxOcta;
        private Label label1;
        private Controls.ImageLabel pictureBoxOctaQuad;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFirmware));
            this.pictureBoxAPM = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxQuad = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxHexa = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxTri = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxY6 = new MissionPlanner.Controls.ImageLabel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHeli = new MissionPlanner.Controls.ImageLabel();
            this.BUT_setup = new MissionPlanner.Controls.MyButton();
            this.pictureBoxHilimage = new System.Windows.Forms.PictureBox();
            this.pictureBoxAPHil = new System.Windows.Forms.PictureBox();
            this.pictureBoxACHil = new System.Windows.Forms.PictureBox();
            this.pictureBoxACHHil = new System.Windows.Forms.PictureBox();
            this.pictureBoxOcta = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxOctaQuad = new MissionPlanner.Controls.ImageLabel();
            this.pictureBoxRover = new MissionPlanner.Controls.ImageLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_history = new System.Windows.Forms.ComboBox();
            this.CMB_history_label = new System.Windows.Forms.Label();
            this.lbl_Custom_firmware_label = new System.Windows.Forms.Label();
            this.lbl_devfw = new System.Windows.Forms.Label();
            this.lbl_px4io = new System.Windows.Forms.Label();
            this.lbl_dlfw = new System.Windows.Forms.Label();
            this.lbl_px4bl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHilimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAPHil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACHil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACHHil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAPM
            // 
            this.pictureBoxAPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAPM.Image = global::MissionPlanner.Properties.Resources.APM_airframes_001;
            resources.ApplyResources(this.pictureBoxAPM, "pictureBoxAPM");
            this.pictureBoxAPM.Name = "pictureBoxAPM";
            this.pictureBoxAPM.TabStop = false;
            this.pictureBoxAPM.Tag = "";
            this.pictureBoxAPM.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxQuad
            // 
            this.pictureBoxQuad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuad.Image = global::MissionPlanner.Properties.Resources.FW_icons_2013_logos_04;
            resources.ApplyResources(this.pictureBoxQuad, "pictureBoxQuad");
            this.pictureBoxQuad.Name = "pictureBoxQuad";
            this.pictureBoxQuad.TabStop = false;
            this.pictureBoxQuad.Tag = "";
            this.pictureBoxQuad.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxHexa
            // 
            this.pictureBoxHexa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHexa.Image = global::MissionPlanner.Properties.Resources.FW_icons_2013_logos_10;
            resources.ApplyResources(this.pictureBoxHexa, "pictureBoxHexa");
            this.pictureBoxHexa.Name = "pictureBoxHexa";
            this.pictureBoxHexa.TabStop = false;
            this.pictureBoxHexa.Tag = "";
            this.pictureBoxHexa.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxTri
            // 
            this.pictureBoxTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTri.Image = global::MissionPlanner.Properties.Resources.FW_icons_2013_logos_08;
            resources.ApplyResources(this.pictureBoxTri, "pictureBoxTri");
            this.pictureBoxTri.Name = "pictureBoxTri";
            this.pictureBoxTri.TabStop = false;
            this.pictureBoxTri.Tag = "";
            this.pictureBoxTri.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxY6
            // 
            this.pictureBoxY6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxY6.Image = global::MissionPlanner.Properties.Resources.y6;
            resources.ApplyResources(this.pictureBoxY6, "pictureBoxY6");
            this.pictureBoxY6.Name = "pictureBoxY6";
            this.pictureBoxY6.TabStop = false;
            this.pictureBoxY6.Tag = "";
            this.pictureBoxY6.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // progress
            // 
            resources.ApplyResources(this.progress, "progress");
            this.progress.Name = "progress";
            this.progress.Step = 1;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBoxHeli
            // 
            this.pictureBoxHeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHeli.Image = global::MissionPlanner.Properties.Resources.APM_airframes_08;
            resources.ApplyResources(this.pictureBoxHeli, "pictureBoxHeli");
            this.pictureBoxHeli.Name = "pictureBoxHeli";
            this.pictureBoxHeli.TabStop = false;
            this.pictureBoxHeli.Tag = "";
            this.pictureBoxHeli.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // BUT_setup
            // 
            resources.ApplyResources(this.BUT_setup, "BUT_setup");
            this.BUT_setup.Name = "BUT_setup";
            this.BUT_setup.UseVisualStyleBackColor = true;
            // 
            // pictureBoxHilimage
            // 
            this.pictureBoxHilimage.Image = global::MissionPlanner.Properties.Resources.hil;
            resources.ApplyResources(this.pictureBoxHilimage, "pictureBoxHilimage");
            this.pictureBoxHilimage.Name = "pictureBoxHilimage";
            this.pictureBoxHilimage.TabStop = false;
            this.pictureBoxHilimage.Tag = "";
            // 
            // pictureBoxAPHil
            // 
            this.pictureBoxAPHil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAPHil.Image = global::MissionPlanner.Properties.Resources.hilplane;
            resources.ApplyResources(this.pictureBoxAPHil, "pictureBoxAPHil");
            this.pictureBoxAPHil.Name = "pictureBoxAPHil";
            this.pictureBoxAPHil.TabStop = false;
            this.pictureBoxAPHil.Tag = "";
            this.pictureBoxAPHil.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxACHil
            // 
            this.pictureBoxACHil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxACHil.Image = global::MissionPlanner.Properties.Resources.hilquad;
            resources.ApplyResources(this.pictureBoxACHil, "pictureBoxACHil");
            this.pictureBoxACHil.Name = "pictureBoxACHil";
            this.pictureBoxACHil.TabStop = false;
            this.pictureBoxACHil.Tag = "";
            this.pictureBoxACHil.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxACHHil
            // 
            this.pictureBoxACHHil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxACHHil.Image = global::MissionPlanner.Properties.Resources.hilheli;
            resources.ApplyResources(this.pictureBoxACHHil, "pictureBoxACHHil");
            this.pictureBoxACHHil.Name = "pictureBoxACHHil";
            this.pictureBoxACHHil.TabStop = false;
            this.pictureBoxACHHil.Tag = "";
            this.pictureBoxACHHil.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxOcta
            // 
            this.pictureBoxOcta.Image = global::MissionPlanner.Properties.Resources.FW_icons_2013_logos_12;
            resources.ApplyResources(this.pictureBoxOcta, "pictureBoxOcta");
            this.pictureBoxOcta.Name = "pictureBoxOcta";
            this.pictureBoxOcta.TabStop = false;
            this.pictureBoxOcta.Tag = "";
            this.pictureBoxOcta.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxOctaQuad
            // 
            this.pictureBoxOctaQuad.Image = global::MissionPlanner.Properties.Resources.x8;
            resources.ApplyResources(this.pictureBoxOctaQuad, "pictureBoxOctaQuad");
            this.pictureBoxOctaQuad.Name = "pictureBoxOctaQuad";
            this.pictureBoxOctaQuad.TabStop = false;
            this.pictureBoxOctaQuad.Tag = "";
            this.pictureBoxOctaQuad.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // pictureBoxRover
            // 
            this.pictureBoxRover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRover.Image = global::MissionPlanner.Properties.Resources.rover_11;
            resources.ApplyResources(this.pictureBoxRover, "pictureBoxRover");
            this.pictureBoxRover.Name = "pictureBoxRover";
            this.pictureBoxRover.TabStop = false;
            this.pictureBoxRover.Tag = "";
            this.pictureBoxRover.Click += new System.EventHandler(this.pictureBoxFW_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CMB_history
            // 
            this.CMB_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_history.DropDownWidth = 160;
            this.CMB_history.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_history, "CMB_history");
            this.CMB_history.Name = "CMB_history";
            this.CMB_history.SelectedIndexChanged += new System.EventHandler(this.CMB_history_SelectedIndexChanged);
            // 
            // CMB_history_label
            // 
            resources.ApplyResources(this.CMB_history_label, "CMB_history_label");
            this.CMB_history_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMB_history_label.Name = "CMB_history_label";
            this.CMB_history_label.Click += new System.EventHandler(this.CMB_history_label_Click);
            // 
            // lbl_Custom_firmware_label
            // 
            resources.ApplyResources(this.lbl_Custom_firmware_label, "lbl_Custom_firmware_label");
            this.lbl_Custom_firmware_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Custom_firmware_label.Name = "lbl_Custom_firmware_label";
            this.lbl_Custom_firmware_label.Click += new System.EventHandler(this.Custom_firmware_label_Click);
            // 
            // lbl_devfw
            // 
            resources.ApplyResources(this.lbl_devfw, "lbl_devfw");
            this.lbl_devfw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_devfw.Name = "lbl_devfw";
            this.lbl_devfw.Click += new System.EventHandler(this.lbl_devfw_Click);
            // 
            // lbl_px4io
            // 
            resources.ApplyResources(this.lbl_px4io, "lbl_px4io");
            this.lbl_px4io.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_px4io.Name = "lbl_px4io";
            this.lbl_px4io.Click += new System.EventHandler(this.lbl_px4io_Click);
            // 
            // lbl_dlfw
            // 
            resources.ApplyResources(this.lbl_dlfw, "lbl_dlfw");
            this.lbl_dlfw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dlfw.Name = "lbl_dlfw";
            this.lbl_dlfw.Click += new System.EventHandler(this.lbl_dlfw_Click);
            // 
            // lbl_px4bl
            // 
            resources.ApplyResources(this.lbl_px4bl, "lbl_px4bl");
            this.lbl_px4bl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_px4bl.Name = "lbl_px4bl";
            this.lbl_px4bl.Click += new System.EventHandler(this.lbl_px4bl_Click);
            // 
            // ConfigFirmware
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_px4bl);
            this.Controls.Add(this.lbl_dlfw);
            this.Controls.Add(this.lbl_px4io);
            this.Controls.Add(this.lbl_devfw);
            this.Controls.Add(this.lbl_Custom_firmware_label);
            this.Controls.Add(this.CMB_history_label);
            this.Controls.Add(this.pictureBoxRover);
            this.Controls.Add(this.CMB_history);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BUT_setup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.pictureBoxACHHil);
            this.Controls.Add(this.pictureBoxACHil);
            this.Controls.Add(this.pictureBoxAPHil);
            this.Controls.Add(this.pictureBoxHilimage);
            this.Controls.Add(this.pictureBoxOctaQuad);
            this.Controls.Add(this.pictureBoxOcta);
            this.Controls.Add(this.pictureBoxHeli);
            this.Controls.Add(this.pictureBoxY6);
            this.Controls.Add(this.pictureBoxTri);
            this.Controls.Add(this.pictureBoxHexa);
            this.Controls.Add(this.pictureBoxQuad);
            this.Controls.Add(this.pictureBoxAPM);
            this.Name = "ConfigFirmware";
            this.Load += new System.EventHandler(this.Firmware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHilimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAPHil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACHil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxACHHil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox CMB_history;
        private Controls.ImageLabel pictureBoxRover;
        private Label CMB_history_label;
        private Label lbl_Custom_firmware_label;
        private Label lbl_devfw;
        private Label lbl_px4io;
        private Label lbl_dlfw;
        private Label lbl_px4bl;

    }
}