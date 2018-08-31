Option Strict On
Imports System.IO
Imports System.Text
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Public Class Form4

    Private Sub ÀproposdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀproposdeToolStripMenuItem.Click
        MsgBox("Éditeur de texte très simple et efficace  ")
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click

    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        Dim fl As String
        ofd.ShowDialog()
        fl = ofd.FileName
        Dim sr As New StreamReader(fl)
        RichTextBox1.Text = sr.ReadToEnd()
        sr.Close()
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RétablirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RétablirToolStripMenuItem.Click
        RichTextBox1.ClearUndo()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub SélectionnertoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SélectionnertoutToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        Dim sv As String
        sfd.ShowDialog()
        sv = sfd.FileName
        Dim sw As New StreamWriter(sv)
        sw.Write(RichTextBox1.Text)
        sw.Close()
    End Sub



    Private Sub HeureDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeureDateToolStripMenuItem.Click
        RichTextBox1.Text = RichTextBox1.Text + " " + CStr(DateTime.Now)
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CouleurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouleurToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub PoliceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliceToolStripMenuItem.Click
        If (FontDialog1.ShowDialog() = DialogResult.OK) Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub
End Class