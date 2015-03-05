Imports System.Security.Cryptography
Imports System.Text

''' <summary>
''' Creates a hash from a string input.
''' </summary>
''' <remarks>This class is a one-way encryption method. The value it returns cannot be decrypted, because a random salt value is added to increase security.</remarks>
Public Class HashSaltFactory
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="valueToHash">Hashed Value</param>
    ''' <param name="salt">Salt</param>
    ''' <returns>Hashed value with added salt.</returns>
    ''' <remarks>Must have salt before using.</remarks>
    Public Function CreateHash(valueToHash As String, salt As String) As String

        Dim value As String = String.Concat(valueToHash, salt)
        Dim algorithm As HashAlgorithm = SHA1.Create()
        Dim data As Byte() = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value))
        Return Convert.ToBase64String(data)

    End Function

    ''' <summary>
    ''' Method generates and returns a random salt value. Salt value is added to a string before hashing to increase security.
    ''' </summary>
    ''' <returns>Salt value</returns>
    ''' <remarks></remarks>
    Public Function CreateSalt() As String
        Const minRange As Integer = 5
        Const maxRange As Integer = 10
        Dim random As New Random
        Dim randomSize As Decimal = random.Next(minRange, maxRange)
        Dim randomValue As String
        randomValue = Convert.ToString(randomSize)
        Dim rng As New RNGCryptoServiceProvider
        Dim buff As Byte() = Encoding.Unicode.GetBytes(randomValue)
        rng.GetBytes(buff)

        Return Convert.ToBase64String(buff)
    End Function

End Class
