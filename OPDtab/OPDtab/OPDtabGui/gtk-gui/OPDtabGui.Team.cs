
// This file has been generated by the GUI designer. Do not modify.
namespace OPDtabGui
{
	public partial class Team
	{
		private global::Gtk.VBox vbox;
		private global::Gtk.HBox hbox;
		private global::Gtk.Alignment alBtn;
		private global::Gtk.Alignment alConflictBtn;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Label lblQualiInd;
		private global::Gtk.HBox hboxTeamMembers;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vboxTeamMembers;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget OPDtabGui.Team
			global::Stetic.BinContainer.Attach (this);
			this.Name = "OPDtabGui.Team";
			// Container child OPDtabGui.Team.Gtk.Container+ContainerChild
			this.vbox = new global::Gtk.VBox ();
			this.vbox.Name = "vbox";
			// Container child vbox.Gtk.Box+BoxChild
			this.hbox = new global::Gtk.HBox ();
			this.hbox.Name = "hbox";
			this.hbox.Spacing = 3;
			// Container child hbox.Gtk.Box+BoxChild
			this.alBtn = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alBtn.Name = "alBtn";
			this.hbox.Add (this.alBtn);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox [this.alBtn]));
			w1.Position = 0;
			// Container child hbox.Gtk.Box+BoxChild
			this.alConflictBtn = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alConflictBtn.Name = "alConflictBtn";
			this.hbox.Add (this.alConflictBtn);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox [this.alConflictBtn]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.lblQualiInd = new global::Gtk.Label ();
			this.lblQualiInd.Name = "lblQualiInd";
			this.alignment2.Add (this.lblQualiInd);
			this.hbox.Add (this.alignment2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox [this.alignment2]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox.Add (this.hbox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hbox]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox.Gtk.Box+BoxChild
			this.hboxTeamMembers = new global::Gtk.HBox ();
			this.hboxTeamMembers.Name = "hboxTeamMembers";
			this.hboxTeamMembers.Spacing = 6;
			// Container child hboxTeamMembers.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 10;
			this.label2.Name = "label2";
			this.hboxTeamMembers.Add (this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxTeamMembers [this.label2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hboxTeamMembers.Gtk.Box+BoxChild
			this.vboxTeamMembers = new global::Gtk.VBox ();
			this.vboxTeamMembers.Name = "vboxTeamMembers";
			this.hboxTeamMembers.Add (this.vboxTeamMembers);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxTeamMembers [this.vboxTeamMembers]));
			w7.Position = 1;
			this.vbox.Add (this.hboxTeamMembers);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hboxTeamMembers]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.Add (this.vbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
