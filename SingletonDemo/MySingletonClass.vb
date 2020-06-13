Option Explicit On

'The Singleton pattern is implemented in two steps:
'   1. Ensure that every constructor in the class implementing the Singleton pattern is Non-Public. All constructors must be Protected or Private. 
'   2. Implement a Public shared method that creates just one instance of the class.

'How do a private constructor and a shared factory method ensure that there is only one instance of the class? 
'   The answer is that consumers cannot invoke non-Public constructors; hence they cannot create instances of your class except in the manner you prescribe (example the "Create()" method or the "GetInstance()" property below).
'   However, member methods can invoke protected or private methods and can call your Non-Public constructors. 
'   The result is that you control the number of instances of your class by controlling access to the constructor.

Public Class MySingletonClass

    Private Shared oMSC As MySingletonClass = Nothing

    Private Sub New()   'PRIVATE constructor disallowing others to create this object directly 
    End Sub

    'Instantiate this class by either 2 ways: Create() method or GetInstance() property
    Public Shared Function Create() As MySingletonClass
        If (oMSC Is Nothing) Then oMSC = New MySingletonClass
        Return oMSC
    End Function

    Public Shared ReadOnly Property GetInstance()
        Get
            If (oMSC Is Nothing) Then oMSC = New MySingletonClass
            Return oMSC
        End Get
    End Property


    'test methods:
    Private InnerList As New Collections.ArrayList()
    Public ReadOnly Property List As Collections.ArrayList
        Get
            Return InnerList
        End Get
    End Property

End Class
