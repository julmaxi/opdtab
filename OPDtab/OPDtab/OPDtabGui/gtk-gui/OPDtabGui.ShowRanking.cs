
// This file has been generated by the GUI designer. Do not modify.
namespace OPDtabGui
{
	public partial class ShowRanking
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Alignment cTeamsFilter;
		private global::Gtk.CheckButton cbTeamsOnlyHighlight;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.Table tableTeams;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Alignment cSpeakersFilter;
		private global::Gtk.CheckButton cbSpeakersOnlyHighlight;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.Table tableSpeakers;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.Table tableJudges;
		private global::Gtk.Label label10;
		private global::Gtk.Label label11;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HButtonBox hbuttonbox1;
		private global::Gtk.Button btnExportPDF;
		private global::Gtk.Button btnExportCSV;
		private global::Gtk.Button btnUpdate;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label12;
		private global::Gtk.ComboBox cbSelectMarking;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.Table tableRounds;
		private global::Gtk.Label label13;
		private global::Gtk.Label label5;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Table tableAvgPoints;
		private global::Gtk.Label label14;
		private global::Gtk.Label label15;
		private global::Gtk.Label label16;
		private global::Gtk.Label label17;
		private global::Gtk.Label label18;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
		private global::Gtk.Label label21;
		private global::Gtk.Label label22;
		private global::Gtk.Label label23;
		private global::Gtk.Label label24;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.Label label4;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget OPDtabGui.ShowRanking
			this.Name = "OPDtabGui.ShowRanking";
			this.Title = global::Mono.Unix.Catalog.GetString ("ShowRanking");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("OPDtabGui.AppIcon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child OPDtabGui.ShowRanking.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 3;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.cTeamsFilter = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.cTeamsFilter.Name = "cTeamsFilter";
			this.cTeamsFilter.LeftPadding = ((uint)(6));
			this.hbox2.Add (this.cTeamsFilter);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.cTeamsFilter]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.cbTeamsOnlyHighlight = new global::Gtk.CheckButton ();
			this.cbTeamsOnlyHighlight.CanFocus = true;
			this.cbTeamsOnlyHighlight.Name = "cbTeamsOnlyHighlight";
			this.cbTeamsOnlyHighlight.Label = global::Mono.Unix.Catalog.GetString ("Only Highlight");
			this.cbTeamsOnlyHighlight.Active = true;
			this.cbTeamsOnlyHighlight.DrawIndicator = true;
			this.cbTeamsOnlyHighlight.UseUnderline = true;
			this.hbox2.Add (this.cbTeamsOnlyHighlight);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.cbTeamsOnlyHighlight]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w4 = new global::Gtk.Viewport ();
			w4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.tableTeams = new global::Gtk.Table (((uint)(3)), ((uint)(6)), false);
			this.tableTeams.Name = "tableTeams";
			// Container child tableTeams.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Team</b>");
			this.label8.UseMarkup = true;
			this.tableTeams.Add (this.label8);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tableTeams [this.label8]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(6));
			w5.XPadding = ((uint)(6));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTeams.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Pos</b>");
			this.label9.UseMarkup = true;
			this.tableTeams.Add (this.label9);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tableTeams [this.label9]));
			w6.XPadding = ((uint)(6));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			w4.Add (this.tableTeams);
			this.GtkScrolledWindow1.Add (w4);
			this.vbox3.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow1]));
			w9.Position = 1;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Teams");
			this.notebook1.SetTabLabel (this.vbox3, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.cSpeakersFilter = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.cSpeakersFilter.Name = "cSpeakersFilter";
			this.cSpeakersFilter.LeftPadding = ((uint)(6));
			this.hbox3.Add (this.cSpeakersFilter);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.cSpeakersFilter]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.cbSpeakersOnlyHighlight = new global::Gtk.CheckButton ();
			this.cbSpeakersOnlyHighlight.CanFocus = true;
			this.cbSpeakersOnlyHighlight.Name = "cbSpeakersOnlyHighlight";
			this.cbSpeakersOnlyHighlight.Label = global::Mono.Unix.Catalog.GetString ("Only Highlight");
			this.cbSpeakersOnlyHighlight.Active = true;
			this.cbSpeakersOnlyHighlight.DrawIndicator = true;
			this.cbSpeakersOnlyHighlight.UseUnderline = true;
			this.hbox3.Add (this.cbSpeakersOnlyHighlight);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.cbSpeakersOnlyHighlight]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w14 = new global::Gtk.Viewport ();
			w14.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.tableSpeakers = new global::Gtk.Table (((uint)(3)), ((uint)(6)), false);
			this.tableSpeakers.Name = "tableSpeakers";
			// Container child tableSpeakers.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Pos</b>");
			this.label6.UseMarkup = true;
			this.tableSpeakers.Add (this.label6);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tableSpeakers [this.label6]));
			w15.XPadding = ((uint)(6));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSpeakers.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Speaker</b>");
			this.label7.UseMarkup = true;
			this.tableSpeakers.Add (this.label7);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tableSpeakers [this.label7]));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(6));
			w16.XPadding = ((uint)(6));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			w14.Add (this.tableSpeakers);
			this.GtkScrolledWindow.Add (w14);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w19.Position = 1;
			this.notebook1.Add (this.vbox1);
			global::Gtk.Notebook.NotebookChild w20 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox1]));
			w20.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Speakers");
			this.notebook1.SetTabLabel (this.vbox1, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w21 = new global::Gtk.Viewport ();
			w21.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport2.Gtk.Container+ContainerChild
			this.tableJudges = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
			this.tableJudges.Name = "tableJudges";
			this.tableJudges.ColumnSpacing = ((uint)(6));
			// Container child tableJudges.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Judge</b>");
			this.label10.UseMarkup = true;
			this.tableJudges.Add (this.label10);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableJudges [this.label10]));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableJudges.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Stats</b>");
			this.label11.UseMarkup = true;
			this.tableJudges.Add (this.label11);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.tableJudges [this.label11]));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			w21.Add (this.tableJudges);
			this.GtkScrolledWindow2.Add (w21);
			this.notebook1.Add (this.GtkScrolledWindow2);
			global::Gtk.Notebook.NotebookChild w26 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.GtkScrolledWindow2]));
			w26.Position = 2;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Judges");
			this.notebook1.SetTabLabel (this.GtkScrolledWindow2, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnExportPDF = new global::Gtk.Button ();
			this.btnExportPDF.CanFocus = true;
			this.btnExportPDF.Name = "btnExportPDF";
			this.btnExportPDF.UseUnderline = true;
			this.btnExportPDF.Label = global::Mono.Unix.Catalog.GetString ("Export as PDF");
			this.hbuttonbox1.Add (this.btnExportPDF);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.btnExportPDF]));
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnExportCSV = new global::Gtk.Button ();
			this.btnExportCSV.CanFocus = true;
			this.btnExportCSV.Name = "btnExportCSV";
			this.btnExportCSV.UseUnderline = true;
			this.btnExportCSV.Label = global::Mono.Unix.Catalog.GetString ("Export as CSV");
			this.hbuttonbox1.Add (this.btnExportCSV);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.btnExportCSV]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnUpdate = new global::Gtk.Button ();
			this.btnUpdate.CanFocus = true;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseUnderline = true;
			// Container child btnUpdate.Gtk.Container+ContainerChild
			global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w30 = new global::Gtk.HBox ();
			w30.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-redo", global::Gtk.IconSize.Menu);
			w30.Add (w31);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w33 = new global::Gtk.Label ();
			w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Update All");
			w33.UseUnderline = true;
			w30.Add (w33);
			w29.Add (w30);
			this.btnUpdate.Add (w29);
			this.hbuttonbox1.Add (this.btnUpdate);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.btnUpdate]));
			w37.Position = 2;
			w37.Expand = false;
			w37.Fill = false;
			this.vbox2.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbuttonbox1]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Mark Break:");
			this.hbox1.Add (this.label12);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label12]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cbSelectMarking = global::Gtk.ComboBox.NewText ();
			this.cbSelectMarking.Name = "cbSelectMarking";
			this.hbox1.Add (this.cbSelectMarking);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.cbSelectMarking]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0F, 0F, 0F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 0F, 0F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.GtkAlignment1.TopPadding = ((uint)(6));
			this.GtkAlignment1.RightPadding = ((uint)(6));
			this.GtkAlignment1.BottomPadding = ((uint)(6));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.tableRounds = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
			this.tableRounds.Name = "tableRounds";
			this.tableRounds.RowSpacing = ((uint)(6));
			this.tableRounds.ColumnSpacing = ((uint)(6));
			// Container child tableRounds.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.tableRounds.Add (this.label13);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.tableRounds [this.label13]));
			w42.LeftAttach = ((uint)(2));
			w42.RightAttach = ((uint)(3));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableRounds.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Gov / Opp");
			this.tableRounds.Add (this.label5);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.tableRounds [this.label5]));
			w43.LeftAttach = ((uint)(3));
			w43.RightAttach = ((uint)(4));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(0));
			this.GtkAlignment1.Add (this.tableRounds);
			this.frame1.Add (this.GtkAlignment1);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Selected Rounds</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel5;
			this.alignment1.Add (this.frame1);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w47.Position = 2;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0F, 0F, 0F, 0F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 0F, 0F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			this.GtkAlignment2.TopPadding = ((uint)(6));
			this.GtkAlignment2.RightPadding = ((uint)(6));
			this.GtkAlignment2.BottomPadding = ((uint)(6));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.tableAvgPoints = new global::Gtk.Table (((uint)(12)), ((uint)(2)), false);
			this.tableAvgPoints.Name = "tableAvgPoints";
			this.tableAvgPoints.RowSpacing = ((uint)(6));
			this.tableAvgPoints.ColumnSpacing = ((uint)(6));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Gov1</small>");
			this.label14.UseMarkup = true;
			this.tableAvgPoints.Add (this.label14);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label14]));
			w48.TopAttach = ((uint)(1));
			w48.BottomAttach = ((uint)(2));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 0F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Opp1</small>");
			this.label15.UseMarkup = true;
			this.tableAvgPoints.Add (this.label15);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label15]));
			w49.TopAttach = ((uint)(2));
			w49.BottomAttach = ((uint)(3));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Gov2</small>");
			this.label16.UseMarkup = true;
			this.tableAvgPoints.Add (this.label16);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label16]));
			w50.TopAttach = ((uint)(3));
			w50.BottomAttach = ((uint)(4));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Opp2</small>");
			this.label17.UseMarkup = true;
			this.tableAvgPoints.Add (this.label17);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label17]));
			w51.TopAttach = ((uint)(4));
			w51.BottomAttach = ((uint)(5));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.Xalign = 0F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Free1</small>");
			this.label18.UseMarkup = true;
			this.tableAvgPoints.Add (this.label18);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label18]));
			w52.TopAttach = ((uint)(5));
			w52.BottomAttach = ((uint)(6));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.Xalign = 0F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Free2</small>");
			this.label19.UseMarkup = true;
			this.tableAvgPoints.Add (this.label19);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label19]));
			w53.TopAttach = ((uint)(6));
			w53.BottomAttach = ((uint)(7));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 0F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Free3</small>");
			this.label20.UseMarkup = true;
			this.tableAvgPoints.Add (this.label20);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label20]));
			w54.TopAttach = ((uint)(7));
			w54.BottomAttach = ((uint)(8));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 0F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Opp3</small>");
			this.label21.UseMarkup = true;
			this.tableAvgPoints.Add (this.label21);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label21]));
			w55.TopAttach = ((uint)(8));
			w55.BottomAttach = ((uint)(9));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.Xalign = 0F;
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Gov3</small>");
			this.label22.UseMarkup = true;
			this.tableAvgPoints.Add (this.label22);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label22]));
			w56.TopAttach = ((uint)(9));
			w56.BottomAttach = ((uint)(10));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.Xalign = 0F;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Gov</small>");
			this.label23.UseMarkup = true;
			this.tableAvgPoints.Add (this.label23);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label23]));
			w57.TopAttach = ((uint)(10));
			w57.BottomAttach = ((uint)(11));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableAvgPoints.Gtk.Table+TableChild
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.Xalign = 0F;
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>Opp</small>");
			this.label24.UseMarkup = true;
			this.tableAvgPoints.Add (this.label24);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.tableAvgPoints [this.label24]));
			w58.TopAttach = ((uint)(11));
			w58.BottomAttach = ((uint)(12));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(0));
			this.GtkAlignment2.Add (this.tableAvgPoints);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Average Points</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel6;
			this.alignment2.Add (this.frame2);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w62.Position = 3;
			w62.Expand = false;
			w62.Fill = false;
			this.notebook1.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w63 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox2]));
			w63.Position = 3;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Options & Tools");
			this.notebook1.SetTabLabel (this.vbox2, this.label4);
			this.label4.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 498;
			this.DefaultHeight = 780;
			this.Hide ();
			this.cbTeamsOnlyHighlight.Toggled += new global::System.EventHandler (this.OnCbTeamsOnlyHighlightToggled);
			this.cbSpeakersOnlyHighlight.Toggled += new global::System.EventHandler (this.OnCbSpeakersOnlyHighlightToggled);
			this.btnExportPDF.Clicked += new global::System.EventHandler (this.OnBtnExportPDFClicked);
			this.btnExportCSV.Clicked += new global::System.EventHandler (this.OnBtnExportCSVClicked);
			this.btnUpdate.Clicked += new global::System.EventHandler (this.OnBtnUpdateClicked);
			this.cbSelectMarking.Changed += new global::System.EventHandler (this.OnCbSelectMarkingChanged);
		}
	}
}
