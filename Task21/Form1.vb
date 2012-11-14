Public Class Form1
    Dim spray, fill, drawing, saved As Boolean
    Dim pen As Boolean = True
    Dim paper As System.Drawing.Graphics
    Dim picture_bmp As Bitmap
    Dim oldx, oldy As Integer
    Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black, 1)
    Dim mousepos As Point
    Dim filename As String
    Dim saveas As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picture_bmp = New Bitmap(PictureBox1.ClientRectangle.Width, PictureBox1.ClientRectangle.Height)
        paper = Graphics.FromImage(picture_bmp)
        myPen.SetLineCap(Drawing2D.LineCap.Round, Drawing2D.LineCap.Round, Drawing2D.DashCap.Round)
        SprayTimer.Enabled = False
    End Sub
    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        If saved = False Then
            save()
        End If
    End Sub
    Public Sub save()
        SaveFileDialog1.Filter = "images(*.png)|*.png"
        Try
            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                filename = SaveFileDialog1.FileName
                picture_bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png)
                saved = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drawing = True
        oldx = e.X
        oldy = e.Y
        If spray = True Then
            SprayTimer.Enabled = True
        End If
        If fill = True Then
            SafeFloodFill(picture_bmp, e.X, e.Y, myPen.Color)
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drawing = False
        saved = False
    End Sub
    Private Sub SprayTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SprayTimer.Tick
        Randomize()
        'This timer begins when spray is enabled and the right mouse button is held down
        Dim xdev, ydev As Integer
        Dim Point As Integer
        Dim Wrong As Boolean = False
        Dim FinalDiff As Integer
        If drawing And (spray = True) Then
            For Point = 1 To SprayDensity.Value
                'SprayDensity.Value roughly defines number of points created per second
                Do
                    xdev = Int(2 * (PaintRadius.Value + 0.5) * Rnd()) - PaintRadius.Value
                    ydev = Int(2 * (PaintRadius.Value + 0.5) * Rnd()) - PaintRadius.Value
                    'generate random x and y values within a square box around the mouse pointer
                    'defined by PaintRadius.Value
                    FinalDiff = +Math.Abs(Math.Sqrt((xdev ^ 2) + (ydev ^ 2)))
                    'Work out whether the point is more than PaintRadius.Value from the mouse pointer
                    If FinalDiff >= PaintRadius.Value Then
                        Wrong = False
                        'If it is, disregard the point
                    Else
                        Wrong = True
                    End If
                Loop While Not Wrong
                paper.DrawEllipse(myPen, (mousepos.X + xdev), (mousepos.Y + ydev), 1, 1)
                'Draw a point using the xdev and ydev values
            Next Point
            Me.Refresh()
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Randomize()
        If drawing Then
            If pen = True Then
                paper.DrawLine(myPen, oldx, oldy, e.X, e.Y)
                oldx = e.X
                oldy = e.Y
            End If
        End If
        mousepos.X = e.X
        mousepos.Y = e.Y
        Me.Refresh()
    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawImage(picture_bmp, 0, 0)
    End Sub
    Private Sub PaintRadius_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PaintRadius.Scroll
        If spray = False Then
            myPen.Width = PaintRadius.Value
        End If
    End Sub
    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click
        paper.Clear(Color.White)
        saved = False
        Me.Refresh()
    End Sub
    Private Sub LoadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBtn.Click
        Dim filename As String
        Dim newimage As Image
        Try
            With OpenFileDialog1
                filename = ""
                .Filter = "image files (*.gif, *.jpg, *.jpeg, *.bmp, *.png, *.wmf)|*.gif; *.jpg; *.jpeg; *.bmp; *.png; *.wmf|all files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "load picture"
            End With
            If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                filename = OpenFileDialog1.FileName
                newimage = Image.FromFile(filename)
                paper.DrawImage(newimage, 0, 0, PictureBox1.Width, PictureBox1.Height)
                Me.Refresh()
                saved = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SaveBtn.MouseDown
        If e.Button = MouseButtons.Left Then
            If saveas = True Then
                save()
            Else
                picture_bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png)
            End If
        ElseIf e.Button = MouseButtons.Right Then
            If saveas = False Then
                saveas = True
                SaveBtn.Text = "Save As"
            Else
                saveas = False
                SaveBtn.Text = "Save"
            End If
        End If
    End Sub
    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        Try
            If (PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ModeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeBtn.Click
        If pen = True Then
            pen = False
            spray = True
            ModeBtn.Text = "Fill"
            myPen.Width = 1
        ElseIf spray = True Then
            spray = False
            fill = True
            ModeBtn.Text = "Pen"
        ElseIf fill = True Then
            fill = False
            pen = True
            ModeBtn.Text = "Spray"
            myPen.Width = PaintRadius.Value
        End If
    End Sub
    Private Sub ColourButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourButton.Click
        Me.ColorDialog1.ShowDialog()
        myPen.Color = Me.ColorDialog1.Color
        ColourButton.BackColor = Me.ColorDialog1.Color
    End Sub
    Private Sub printerpage_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = e.MarginBounds.X + _
            (e.MarginBounds.Width - picture_bmp.Width) \ 2
        Dim y As Integer = e.MarginBounds.Y + _
            (e.MarginBounds.Height - picture_bmp.Height) \ 2
        e.Graphics.DrawImage(picture_bmp, x, y)
        e.HasMorePages = False
    End Sub
    Public Sub SafeFloodFill(ByVal bm As Bitmap, ByVal x As _
    Integer, ByVal y As Integer, ByVal new_color As Color)
        'taken from http://www.vb-helper.com/howto_net_unsafe_flood.html
        ' Get the old and new colors.
        Dim old_color As Color = bm.GetPixel(x, y)
        If old_color.ToArgb <> new_color.ToArgb Then 'addition by Reuben Joliff to avoid problems
            ' Start with the original point in the stack.
            Dim pts As New Stack(10000)
            pts.Push(New Point(x, y))
            bm.SetPixel(x, y, new_color)
            ' While the stack is not empty, process a point.
            Do While pts.Count > 0
                Dim pt As Point = DirectCast(pts.Pop(), Point)
                If pt.X > 0 Then SafeCheckPoint(bm, pts, pt.X - 1, _
                    pt.Y, old_color, new_color)
                If pt.Y > 0 Then SafeCheckPoint(bm, pts, pt.X, pt.Y _
                    - 1, old_color, new_color)
                If pt.X < bm.Width - 1 Then SafeCheckPoint(bm, pts, _
                    pt.X + 1, pt.Y, old_color, new_color)
                If pt.Y < bm.Height - 1 Then SafeCheckPoint(bm, _
                    pts, pt.X, pt.Y + 1, old_color, new_color)
            Loop
            saved = False
        End If
    End Sub
    ' See if this point should be added to the stack.
    Private Sub SafeCheckPoint(ByVal bm As Bitmap, ByVal pts As  _
        Stack, ByVal x As Integer, ByVal y As Integer, ByVal _
        old_color As Color, ByVal new_color As Color)
        Dim clr As Color = bm.GetPixel(x, y)
        If clr.Equals(old_color) Then
            pts.Push(New Point(x, y))
            bm.SetPixel(x, y, new_color)
        End If
    End Sub
End Class
