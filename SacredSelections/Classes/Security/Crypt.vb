Imports System.Security.Cryptography

''' <summary>
''' Tools for encryption and decryption of strings.
''' </summary>
''' <remarks></remarks>
''' 

Public NotInheritable Class Crypt

    Private TripleDes As New TripleDESCryptoServiceProvider

    Private Const KeyValue As String = "WhenElephantFly^^&%$#^@123789"
    Private Const DefaultKey As String = "HiddedFromView"
    'Method that creates a byte array of a specified length from the hash of the specified key.
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' hash the key
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    'Constructor to initialize the 3DES cryptographic service provider.
    'The key parameter controls the EncryptData and DecryptData methods.
    'This initializer required a boolean so that the class knows whether or not to use a custom key that is defined by the user, or a hardcoded key set by programmer.
    'If the user does not use a custom key, the second parameter is still required but it can be any string bc it is not used at all.
    ''' <summary>
    ''' If not initialized with specific key string then a default key will be used.
    ''' </summary>
    ''' <param name="key">Key</param>
    ''' <remarks>
    ''' </remarks>
    Sub New(Optional ByVal key As String = DefaultKey)
        ' Initialize the crypto provider
        If key = DefaultKey Then
            key &= KeyValue
        End If

        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub



    'Public method that encrypts a string
    Public Function EncryptData(ByVal plaintext As String) As String

        'convert the plaintext string to a byte array.
        Dim plaintextbytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        'create stream
        Dim ms As New System.IO.MemoryStream

        'create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextbytes, 0, plaintextbytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)

    End Function


    'Method that decrypts a string
    Public Function DecryptData(ByVal encryptedtext As String) As String

        'Convert the encrypted text string to a byte array
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        'create stream
        Dim ms As New System.IO.MemoryStream

        'create the decoder to write to the stream
        Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        'Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)

    End Function
End Class
