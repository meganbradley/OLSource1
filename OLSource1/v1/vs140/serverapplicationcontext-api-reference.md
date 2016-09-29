---
title: "ServerApplicationContext API Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5f1de6a1-9356-458b-ae22-39a030984445
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ServerApplicationContext API Reference
This article provides an overview of the `ServerApplicationContext` API, which lets you access the middle tier of a LightSwitch application from other clients.  
  
## Microsoft.LightSwitch.Framework.Server.ServerApplicationContext  
 `Public MustInherit Class ServerApplicationContext(Of TServerApplicationContext As Microsoft.LightSwitch.Server.IServerApplicationContext, TApplication As Microsoft.LightSwitch.Server.IServerApplication, TDataWorkspace As Microsoft.LightSwitch.IDataWorkspace)`  
  
 **Inherits**: System.Object  
  
 **Member of**: Microsoft.LightSwitch.Framework.Server  
  
 **Remarks**: Code that uses the `ServerApplicationContext` must execute on the same thread on which the Http request is handled. Once the request is handled, the objects encapsulated in the **ServerApplicationContext** are disposed. If you’re seeing <xref:System.InvalidOperationException*>, <xref:System.ObjectDisposedException*>, or similar exceptions with irregular frequency, check to make sure that your code is running on the same thread on which the Http request is handled. If you do need to start a new thread that will subsequently access the LightSwitch data, you’ll need to copy that data into a standalone collection or object graph before starting the thread.  
  
### Members  
  
||  
|-|  
|[CreateContext()](../vs140/serverapplicationcontext-api-reference.md#createcontext)|  
|[CreateContext(ServerApplicationContextCreationOptions)](../vs140/serverapplicationcontext-api-reference.md#createcontext2)|  
|[Application](../vs140/serverapplicationcontext-api-reference.md#application)|  
|[Current](../vs140/serverapplicationcontext-api-reference.md#current)|  
|[DataWorkspace](../vs140/serverapplicationcontext-api-reference.md#dataworkspace)|  
  
###  <a name="createcontext"></a> CreateContext()  
 `Public Shared Function CreateContext() As TServerApplicationContext`  
  
 Creates a new **ServerApplicationContext** based on the **Application** and **DataWorkspace** properties of the active LightSwitch application.  
  
 **Remarks**: Only one `ServerApplicationContext` can be present for a given logical request on the server. Each incoming request to one of the in-built LightSwitch server endpoints has its own `ServerApplicationContext` automatically created for the lifetime of the request. If you try to create a second `ServerApplicationContext` when one is already present, a `ContextExistsException` will occur.  
  
```vb  
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load  
        Dim ct As ServerApplicationContext = ServerApplicationContext.CreateContext()  
        For Each b As Birthday In ct.DataWorkspace.ApplicationData.Birthdays  
            If b.BirthDate = Date.Today Then  
                Response.Write(b.Id.ToString() + " " + b.Name + " " + b.BirthDate + "<br>" + vbCrLf)  
            End If  
        Next  
        Response.Write("Current user is: " + ct.Application.User.FullName)  
    End Sub  
```  
  
```c#  
protected void Page_Load(object sender, System.EventArgs e)  
{  
ServerApplicationContext ct = ServerApplicationContext.CreateContext();  
foreach (Birthday b in ct.DataWorkspace.ApplicationData.Birthdays) {  
if (b.BirthDate == System.DateTime.Today) {  
Response.Write(b.Id.ToString() + " " + b.Name + " " + b.BirthDate + "<br>" + Constants.vbCrLf);  
}  
}  
Response.Write("Current user is: " + ct.Application.User.FullName);  
}  
  
```  
  
###  <a name="createcontext2"></a> CreateContext(ServerApplicationContextCreationOptions)  
 `Public Shared Function CreateContext(ServerApplicationContextCreationOptions) As TServerApplicationContext`  
  
 Creates a new **ServerApplicationContext** based on the **Application** and **DataWorkspace** properties of the active LightSwitch application, with a parameter that specifies whether authentication is required.  
  
 **Parameter**: `ServerApplicationContextCreationOptions` of type `Microsoft.LightSwitch.Server.ServerApplicationContextCreationOptions`.  
  
 **Values**:  
  
 `None` (0) – Authentication is required, if enabled for the application.  
  
 `SkipAuthentication` (1) – Authentication is bypassed.  
  
 **Remarks**: Only one `ServerApplicationContext` can be present for a given logical request on the server. Each incoming request to one of the in-built LightSwitch server endpoints has its own `ServerApplicationContext` automatically created for the lifetime of the request. If you try to create a second `ServerApplicationContext` when one is already present, a `ContextExistsException` will occur.  
  
 If authentication is enabled for your LightSwitch application,  `ServerApplicationContext` tries to enforce user authentication. Specifically, if in your web.config file the **Authentication** mode is **Windows** or **Forms**, when your code tries to create a new `ServerApplicationContext` by calling `CreateContext`, if there isn't a valid authenticated user already on the **HttpContext**, your call to **CreateContext** will throw an exception.  
  
 If you don’t want this behavior, you can tell **CreateContext** to skip the authentication check, by setting the `ServerApplicationContextCreationOptions` parameter to `SkipAuthentication`.  
  
> [!CAUTION]
>  If you use the `SkipAuthentication` option, creating and using the context will succeed without first establishing the identity of the user.  The lifetime of the `ServerApplicationContext` is limited to just the code inside the `Using` block. If you're using the `SkipAuthentication` option, don't write security sensitive code inside the `Using` block.  
  
```vb  
Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext(ServerApplicationContextCreationOptions.SkipAuthentication)   
' allow in unauthenticated users   
' your code goes here   
End Using  
```  
  
```c#  
using (ServerApplicationContext Context = ServerApplicationContext.CreateContext(ServerApplicationContextCreationOptions.SkipAuthentication)) {  
// allow in unauthenticated users   
// your code goes here   
}  
```  
  
###  <a name="application"></a> Application  
 `Public ReadOnly Property Application As TApplication`  
  
 Gets the `Application` object for ththe LightSwitch application. The `Application` object provides access to active screens, methods of open screens, and access to the current user.  
  
```vb  
Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load  
        Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext()  
            Response.Write(Context.Application.Details.DisplayName)  
        End Using  
    End Sub  
```  
  
```c#  
protected void Page_Load(object sender, System.EventArgs e)  
{  
using (ServerApplicationContext Context = ServerApplicationContext.CreateContext()) {  
Response.Write(Context.Application.Details.DisplayName);  
}  
}  
```  
  
###  <a name="current"></a> Current  
 `Public Shared ReadOnly Property Current As TServerApplicationContext`  
  
 Returns the currently in-scope `ServerApplicationContext` if one exists; otherwise returns a `NullReferenceException`.  
  
 **Remarks**: The `Current` property can be used instead of the `CreateContext()` method when accessing the `ServerApplicationContext` from a server method such as `Inserting` or `SaveChanges_Executing`. If you attempt to call `CreateContext()` from a server method, a `ContextExistsException` will occur.  
  
```vb  
Private Sub Birthdays_Inserting(entity As Birthday)  
            For Each b As Birthday In ServerApplicationContext.Current.DataWorkspace.ApplicationData.Birthdays  
                If b.BirthDate = Date.Today Then  
                    MsgBox((b.Id.ToString() + " " + b.Name + " " + b.BirthDate))  
                End If  
            Next  
            MsgBox("Current user is: " + ServerApplicationContext.Current.Application.User.FullName)  
        End Sub  
```  
  
```c#  
private void Birthdays_Inserting(Birthday entity)  
{  
foreach (Birthday b in ServerApplicationContext.Current.DataWorkspace.ApplicationData.Birthdays) {  
if (b.BirthDate == System.DateTime.Today) {  
Interaction.MsgBox((b.Id.ToString() + " " + b.Name + " " + b.BirthDate));  
}  
}  
Interaction.MsgBox("Current user is: " + ServerApplicationContext.Current.Application.User.FullName);  
}  
  
```  
  
###  <a name="dataworkspace"></a> DataWorkspace  
 `Public ReadOnly Property DataWorkspace As TDataWorkspace`  
  
 Gets the containing data workspace. The data workspace provides access to all data sources in the application.  
  
```vb  
Using Context As ServerApplicationContext = ServerApplicationContext.CreateContext()   
    Dim v = From c In Context.DataWorkspace.ApplicationData.Customers   
            Where c.Name.Contains("Joe")   
            Select c   
       For Each c As Customer In v   
        Response.Write(c.Name + "<br>" + vbCrLf)    
    Next   
End Using    
```  
  
```c#  
using (ServerApplicationContext context = ServerApplicationContext.CreateContext())   
{    
    var v = from c in context.DataWorkspace.ApplicationData.Customers   
            where c.Name.Contains("Joe")   
            select c;   
       foreach (Customer c in v) {    
        Response.Write(c.Name + "<br>\r\n");   
    }   
}  
```  
  
## See Also  
 [Walkthrough: Inserting Data with the ServerApplicationContext](../vs140/walkthrough--inserting-data-with-the-serverapplicationcontext.md)   
 [LightSwitch ServerApplicationContext](../vs140/lightswitch-serverapplicationcontext.md)