Option Strict On

Imports System.Runtime.CompilerServices

Module ShapedControls

    Public Const Pi As Double = Math.PI
    Public Const DegreesToRadians As Double = 180 / Pi

    Public Enum TriangleDirection
        Up
        Right
        Down
        Left
        TopRight
        BottomRight
        BottomLeft
        TopLeft
    End Enum

    <Extension()> _
    Public Sub Shape(ByVal ctrl As Control, _
Optional ByVal NumberOfSides As Integer = 3, Optional ByVal OffsetAngleInDegrees As Double = 0)

        ' If NumberOfSides < 2 Then Throw New Exception("Number of sides can only be 2 or more.")
        If NumberOfSides < 2 Then NumberOfSides = 2

        Dim MyPath As New Drawing2D.GraphicsPath
        Dim MyAngle As Double = OffsetAngleInDegrees / DegreesToRadians

        If NumberOfSides = 2 Then

            Dim MyPoints() As Point
            Dim MyPointsList As New List(Of Point)

            If ctrl.Width = ctrl.Height Then
                MyPath.AddEllipse(New Rectangle(0, 0, ctrl.Width, ctrl.Height))
            ElseIf ctrl.Width > ctrl.Height Then
                MyPointsList.Add(New Point(0, ctrl.Height \ 2))
                MyPointsList.Add(New Point(ctrl.Width \ 2, 0))
                MyPointsList.Add(New Point(ctrl.Width, ctrl.Height \ 2))
                MyPoints = MyPointsList.ToArray
                MyPath.AddCurve(MyPoints)
                MyPointsList.Clear()

                MyPointsList.Add(New Point(ctrl.Width, ctrl.Height \ 2))
                MyPointsList.Add(New Point(ctrl.Width \ 2, ctrl.Height))
                MyPointsList.Add(New Point(0, ctrl.Height \ 2))
                MyPoints = MyPointsList.ToArray
                MyPath.AddCurve(MyPoints)
                MyPointsList.Clear()
            ElseIf ctrl.Width < ctrl.Height Then
                MyPointsList.Add(New Point(ctrl.Width \ 2, 0))
                MyPointsList.Add(New Point(ctrl.Width, ctrl.Height \ 2))
                MyPointsList.Add(New Point(ctrl.Width \ 2, ctrl.Height))
                MyPoints = MyPointsList.ToArray
                MyPath.AddCurve(MyPoints)
                MyPointsList.Clear()

                MyPointsList.Add(New Point(ctrl.Width \ 2, ctrl.Height))
                MyPointsList.Add(New Point(0, ctrl.Height \ 2))
                MyPointsList.Add(New Point(ctrl.Width \ 2, 0))
                MyPoints = MyPointsList.ToArray
                MyPath.AddCurve(MyPoints)
                MyPointsList.Clear()
            End If
        End If

        Dim radius1 As Integer = ctrl.Height \ 2
        Dim radius2 As Integer = ctrl.Width \ 2
        Dim xInt, yInt As Integer
        Dim xDoub, yDoub As Double

        For angle As Double = MyAngle To ((2 * Pi) + MyAngle) Step ((2 * Pi) / NumberOfSides)

            xDoub = radius2 * Math.Cos(angle) + radius2
            yDoub = radius1 * Math.Sin(angle) + radius1
            xInt = CInt(Int(xDoub))
            yInt = CInt(Int(yDoub))
            MyPath.AddLine(New Point(xInt, yInt), New Point(xInt, yInt))

        Next

        MyPath.CloseFigure()
        ctrl.Region = New Region(MyPath)
        MyPath.Dispose()

    End Sub

    <Extension()> _
    Public Sub MakeTriangular(ByVal ctrl As Control, ByVal Triangle_Direction As TriangleDirection)

        Dim MyPath As New Drawing2D.GraphicsPath

        Select Case Triangle_Direction
            Case Is = TriangleDirection.Up
                MyPath.AddLine(0, ctrl.Height, 0, ctrl.Height)
                MyPath.AddLine(0, ctrl.Height, ctrl.Width \ 2, 0)
                MyPath.AddLine(ctrl.Width \ 2, 0, ctrl.Width, ctrl.Height)
            Case TriangleDirection.Right
                MyPath.AddLine(0, ctrl.Height, 0, 0)
                MyPath.AddLine(0, 0, ctrl.Width, ctrl.Height \ 2)

            Case TriangleDirection.Down
                MyPath.AddLine(0, 0, ctrl.Width, 0)
                MyPath.AddLine(ctrl.Width, 0, ctrl.Width \ 2, ctrl.Height)

            Case TriangleDirection.Left
                MyPath.AddLine(ctrl.Width, 0, ctrl.Width, ctrl.Height)
                MyPath.AddLine(ctrl.Width, ctrl.Height, 0, ctrl.Height \ 2)

            Case TriangleDirection.TopRight
                MyPath.AddLine(0, 0, ctrl.Width, 0)
                MyPath.AddLine(ctrl.Width, 0, ctrl.Width, ctrl.Height)

            Case TriangleDirection.TopLeft
                MyPath.AddLine(0, 0, ctrl.Width, 0)
                MyPath.AddLine(ctrl.Width, 0, 0, ctrl.Height)

            Case TriangleDirection.BottomRight
                MyPath.AddLine(ctrl.Width, 0, ctrl.Width, ctrl.Height)
                MyPath.AddLine(ctrl.Width, ctrl.Height, 0, ctrl.Height)

            Case TriangleDirection.BottomLeft
                MyPath.AddLine(0, 0, ctrl.Width, ctrl.Height)
                MyPath.AddLine(ctrl.Width, ctrl.Height, 0, ctrl.Height)

        End Select
        MyPath.CloseFigure()
        ctrl.Region = New Region(MyPath)

    End Sub

End Module