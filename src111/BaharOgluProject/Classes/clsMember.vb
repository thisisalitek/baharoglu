﻿Public Class clsMember
    Implements IConvertible

    Private mVar_ValueMember As Object
    Private mVar_DisplayMember As String

    Public Property ValueMember() As Object
        Get
            Return mVar_ValueMember
        End Get
        Set(ByVal value As Object)
            mVar_ValueMember = value
        End Set
    End Property

    Public Property DisplayMember() As String
        Get
            Return mVar_DisplayMember
        End Get
        Set(ByVal value As String)
            mVar_DisplayMember = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return mVar_DisplayMember
    End Function

    Public Function GetTypeCode() As System.TypeCode Implements System.IConvertible.GetTypeCode

    End Function

    Public Function ToBoolean(ByVal provider As System.IFormatProvider) As Boolean Implements System.IConvertible.ToBoolean

    End Function

    Public Function ToByte(ByVal provider As System.IFormatProvider) As Byte Implements System.IConvertible.ToByte

    End Function

    Public Function ToChar(ByVal provider As System.IFormatProvider) As Char Implements System.IConvertible.ToChar

    End Function

    Public Function ToDateTime(ByVal provider As System.IFormatProvider) As Date Implements System.IConvertible.ToDateTime

    End Function

    Public Function ToDecimal(ByVal provider As System.IFormatProvider) As Decimal Implements System.IConvertible.ToDecimal

    End Function

    Public Function ToDouble(ByVal provider As System.IFormatProvider) As Double Implements System.IConvertible.ToDouble

    End Function

    Public Function ToInt16(ByVal provider As System.IFormatProvider) As Short Implements System.IConvertible.ToInt16

    End Function

    Public Function ToInt32(ByVal provider As System.IFormatProvider) As Integer Implements System.IConvertible.ToInt32

    End Function

    Public Function ToInt64(ByVal provider As System.IFormatProvider) As Long Implements System.IConvertible.ToInt64

    End Function

    Public Function ToSByte(ByVal provider As System.IFormatProvider) As SByte Implements System.IConvertible.ToSByte

    End Function

    Public Function ToSingle(ByVal provider As System.IFormatProvider) As Single Implements System.IConvertible.ToSingle

    End Function

    Public Function ToString1(ByVal provider As System.IFormatProvider) As String Implements System.IConvertible.ToString
        Return mVar_DisplayMember
    End Function

    Public Function ToType(ByVal conversionType As System.Type, ByVal provider As System.IFormatProvider) As Object Implements System.IConvertible.ToType
        Return GetType(clsMember)
    End Function

    Public Function ToUInt16(ByVal provider As System.IFormatProvider) As UShort Implements System.IConvertible.ToUInt16

    End Function

    Public Function ToUInt32(ByVal provider As System.IFormatProvider) As UInteger Implements System.IConvertible.ToUInt32

    End Function

    Public Function ToUInt64(ByVal provider As System.IFormatProvider) As ULong Implements System.IConvertible.ToUInt64

    End Function
End Class
