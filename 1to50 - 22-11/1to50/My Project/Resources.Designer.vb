﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.18444
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("_1to50.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property _error() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("_error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a .
        '''</summary>
        Friend ReadOnly Property aplausos() As String
            Get
                Return ResourceManager.GetString("aplausos", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property aplausos1() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("aplausos1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a 00:00:34:8     Numeros    0     22/11/2014 12:59     bea
        '''.
        '''</summary>
        Friend ReadOnly Property historialPartidas() As String
            Get
                Return ResourceManager.GetString("historialPartidas", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property reloj() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("reloj", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
