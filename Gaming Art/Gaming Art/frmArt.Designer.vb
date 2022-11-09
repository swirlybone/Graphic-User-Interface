<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Art_IDLabel As System.Windows.Forms.Label
        Dim Artist_NameLabel As System.Windows.Forms.Label
        Dim Art_TitleLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim CollectionLabel As System.Windows.Forms.Label
        Dim Retail_PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArt))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picArt = New System.Windows.Forms.PictureBox()
        Me.ArtDataSet = New Gaming_Art.ArtDataSet()
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistTableAdapter = New Gaming_Art.ArtDataSetTableAdapters.ArtistTableAdapter()
        Me.TableAdapterManager = New Gaming_Art.ArtDataSetTableAdapters.TableAdapterManager()
        Me.ArtistBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArtistBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Art_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Artist_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Art_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.CollectionTextBox = New System.Windows.Forms.TextBox()
        Me.Retail_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.lblTotalRetailValue = New System.Windows.Forms.Label()
        Art_IDLabel = New System.Windows.Forms.Label()
        Artist_NameLabel = New System.Windows.Forms.Label()
        Art_TitleLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CollectionLabel = New System.Windows.Forms.Label()
        Retail_PriceLabel = New System.Windows.Forms.Label()
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArtistBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Art_IDLabel
        '
        Art_IDLabel.AutoSize = True
        Art_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Art_IDLabel.Location = New System.Drawing.Point(12, 217)
        Art_IDLabel.Name = "Art_IDLabel"
        Art_IDLabel.Size = New System.Drawing.Size(55, 16)
        Art_IDLabel.TabIndex = 3
        Art_IDLabel.Text = "Art ID:"
        AddHandler Art_IDLabel.Click, AddressOf Me.Art_IDLabel_Click
        '
        'Artist_NameLabel
        '
        Artist_NameLabel.AutoSize = True
        Artist_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Artist_NameLabel.Location = New System.Drawing.Point(193, 215)
        Artist_NameLabel.Name = "Artist_NameLabel"
        Artist_NameLabel.Size = New System.Drawing.Size(96, 16)
        Artist_NameLabel.TabIndex = 5
        Artist_NameLabel.Text = "Artist Name:"
        AddHandler Artist_NameLabel.Click, AddressOf Me.Artist_NameLabel_Click
        '
        'Art_TitleLabel
        '
        Art_TitleLabel.AutoSize = True
        Art_TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Art_TitleLabel.Location = New System.Drawing.Point(14, 262)
        Art_TitleLabel.Name = "Art_TitleLabel"
        Art_TitleLabel.Size = New System.Drawing.Size(69, 16)
        Art_TitleLabel.TabIndex = 7
        Art_TitleLabel.Text = "Art Title:"
        AddHandler Art_TitleLabel.Click, AddressOf Me.Art_TitleLabel_Click
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(217, 261)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(73, 16)
        LocationLabel.TabIndex = 9
        LocationLabel.Text = "Location:"
        '
        'CollectionLabel
        '
        CollectionLabel.AutoSize = True
        CollectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CollectionLabel.Location = New System.Drawing.Point(12, 313)
        CollectionLabel.Name = "CollectionLabel"
        CollectionLabel.Size = New System.Drawing.Size(84, 16)
        CollectionLabel.TabIndex = 11
        CollectionLabel.Text = "Collection:"
        '
        'Retail_PriceLabel
        '
        Retail_PriceLabel.AutoSize = True
        Retail_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Retail_PriceLabel.Location = New System.Drawing.Point(231, 310)
        Retail_PriceLabel.Name = "Retail_PriceLabel"
        Retail_PriceLabel.Size = New System.Drawing.Size(97, 16)
        Retail_PriceLabel.TabIndex = 13
        Retail_PriceLabel.Text = "Retail Price:"
        AddHandler Retail_PriceLabel.Click, AddressOf Me.Retail_PriceLabel_Click
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Script MT Bold", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Green
        Me.lblTitle.Location = New System.Drawing.Point(326, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(316, 126)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Game Design " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finalists"
        '
        'picArt
        '
        Me.picArt.Image = Global.Gaming_Art.My.Resources.Resources.art
        Me.picArt.Location = New System.Drawing.Point(12, 39)
        Me.picArt.Name = "picArt"
        Me.picArt.Size = New System.Drawing.Size(293, 160)
        Me.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArt.TabIndex = 1
        Me.picArt.TabStop = False
        '
        'ArtDataSet
        '
        Me.ArtDataSet.DataSetName = "ArtDataSet"
        Me.ArtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataMember = "Artist"
        Me.ArtistBindingSource.DataSource = Me.ArtDataSet
        '
        'ArtistTableAdapter
        '
        Me.ArtistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistTableAdapter = Me.ArtistTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Gaming_Art.ArtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtistBindingNavigator
        '
        Me.ArtistBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArtistBindingNavigator.BindingSource = Me.ArtistBindingSource
        Me.ArtistBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArtistBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArtistBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArtistBindingNavigatorSaveItem})
        Me.ArtistBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArtistBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArtistBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArtistBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArtistBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArtistBindingNavigator.Name = "ArtistBindingNavigator"
        Me.ArtistBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArtistBindingNavigator.Size = New System.Drawing.Size(662, 25)
        Me.ArtistBindingNavigator.TabIndex = 2
        Me.ArtistBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ArtistBindingNavigatorSaveItem
        '
        Me.ArtistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArtistBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArtistBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArtistBindingNavigatorSaveItem.Name = "ArtistBindingNavigatorSaveItem"
        Me.ArtistBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ArtistBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Art_IDTextBox
        '
        Me.Art_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Art ID", True))
        Me.Art_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Art_IDTextBox.Location = New System.Drawing.Point(73, 211)
        Me.Art_IDTextBox.Name = "Art_IDTextBox"
        Me.Art_IDTextBox.Size = New System.Drawing.Size(57, 22)
        Me.Art_IDTextBox.TabIndex = 4
        '
        'Artist_NameTextBox
        '
        Me.Artist_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Artist Name", True))
        Me.Artist_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artist_NameTextBox.Location = New System.Drawing.Point(295, 211)
        Me.Artist_NameTextBox.Name = "Artist_NameTextBox"
        Me.Artist_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Artist_NameTextBox.TabIndex = 6
        '
        'Art_TitleTextBox
        '
        Me.Art_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Art Title", True))
        Me.Art_TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Art_TitleTextBox.Location = New System.Drawing.Point(89, 259)
        Me.Art_TitleTextBox.Name = "Art_TitleTextBox"
        Me.Art_TitleTextBox.Size = New System.Drawing.Size(117, 22)
        Me.Art_TitleTextBox.TabIndex = 8
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(296, 258)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(148, 22)
        Me.LocationTextBox.TabIndex = 10
        '
        'CollectionTextBox
        '
        Me.CollectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Collection", True))
        Me.CollectionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollectionTextBox.Location = New System.Drawing.Point(106, 310)
        Me.CollectionTextBox.Name = "CollectionTextBox"
        Me.CollectionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CollectionTextBox.TabIndex = 12
        '
        'Retail_PriceTextBox
        '
        Me.Retail_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Retail Price", True))
        Me.Retail_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retail_PriceTextBox.Location = New System.Drawing.Point(334, 304)
        Me.Retail_PriceTextBox.Name = "Retail_PriceTextBox"
        Me.Retail_PriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Retail_PriceTextBox.TabIndex = 14
        '
        'btnValue
        '
        Me.btnValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValue.ForeColor = System.Drawing.Color.Green
        Me.btnValue.Location = New System.Drawing.Point(260, 341)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(147, 29)
        Me.btnValue.TabIndex = 15
        Me.btnValue.Text = "Total Retail Value"
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'lblTotalRetailValue
        '
        Me.lblTotalRetailValue.AutoSize = True
        Me.lblTotalRetailValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRetailValue.Location = New System.Drawing.Point(202, 383)
        Me.lblTotalRetailValue.Name = "lblTotalRetailValue"
        Me.lblTotalRetailValue.Size = New System.Drawing.Size(285, 20)
        Me.lblTotalRetailValue.TabIndex = 16
        Me.lblTotalRetailValue.Text = "XXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblTotalRetailValue.Visible = False
        '
        'frmArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 421)
        Me.Controls.Add(Me.lblTotalRetailValue)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Retail_PriceLabel)
        Me.Controls.Add(Me.Retail_PriceTextBox)
        Me.Controls.Add(CollectionLabel)
        Me.Controls.Add(Me.CollectionTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Art_TitleLabel)
        Me.Controls.Add(Me.Art_TitleTextBox)
        Me.Controls.Add(Artist_NameLabel)
        Me.Controls.Add(Me.Artist_NameTextBox)
        Me.Controls.Add(Art_IDLabel)
        Me.Controls.Add(Me.Art_IDTextBox)
        Me.Controls.Add(Me.ArtistBindingNavigator)
        Me.Controls.Add(Me.picArt)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmArt"
        Me.Text = "Game Art Comission - Game Art & Design Competition"
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArtistBindingNavigator.ResumeLayout(False)
        Me.ArtistBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picArt As PictureBox
    Friend WithEvents ArtDataSet As ArtDataSet
    Friend WithEvents ArtistBindingSource As BindingSource
    Friend WithEvents ArtistTableAdapter As ArtDataSetTableAdapters.ArtistTableAdapter
    Friend WithEvents TableAdapterManager As ArtDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtistBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ArtistBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Art_IDTextBox As TextBox
    Friend WithEvents Artist_NameTextBox As TextBox
    Friend WithEvents Art_TitleTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CollectionTextBox As TextBox
    Friend WithEvents Retail_PriceTextBox As TextBox
    Friend WithEvents btnValue As Button
    Friend WithEvents lblTotalRetailValue As Label
End Class
