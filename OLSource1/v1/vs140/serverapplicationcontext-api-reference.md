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
This article provides an overview of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> API, which lets you access the middle tier of a LightSwitch application from other clients.  
  
## Microsoft.LightSwitch.Framework.Server.ServerApplicationContext  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 **Inherits**: System.Object  
  
 **Member of**: Microsoft.LightSwitch.Framework.Server  
  
 **Remarks**: Code that uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must execute on the same thread on which the Http request is handled. Once the request is handled, the objects encapsulated in the **ServerApplicationContext** are disposed. If you’re seeing \<xref:System.InvalidOperationException*>, \<xref:System.ObjectDisposedException*>, or similar exceptions with irregular frequency, check to make sure that your code is running on the same thread on which the Http request is handled. If you do need to start a new thread that will subsequently access the LightSwitch data, you’ll need to copy that data into a standalone collection or object graph before starting the thread.  
  
### Members  
  
||  
|-|  
|[CreateContext()](../vs140/serverapplicationcontext-api-reference.md#createcontext)|  
|[CreateContext(ServerApplicationContextCreationOptions)](../vs140/serverapplicationcontext-api-reference.md#createcontext2)|  
|[Application](../vs140/serverapplicationcontext-api-reference.md#application)|  
|[Current](../vs140/serverapplicationcontext-api-reference.md#current)|  
|[DataWorkspace](../vs140/serverapplicationcontext-api-reference.md#dataworkspace)|  
  
###  \<a name="createcontext">\</a> CreateContext()  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 Creates a new **ServerApplicationContext** based on the **Application** and **DataWorkspace** properties of the active LightSwitch application.  
  
 **Remarks**: Only one <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be present for a given logical request on the server. Each incoming request to one of the in-built LightSwitch server endpoints has its own <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> automatically created for the lifetime of the request. If you try to create a second <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> when one is already present, a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> will occur.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
###  \<a name="createcontext2">\</a> CreateContext(ServerApplicationContextCreationOptions)  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 Creates a new **ServerApplicationContext** based on the **Application** and **DataWorkspace** properties of the active LightSwitch application, with a parameter that specifies whether authentication is required.  
  
 **Parameter**: <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 **Values**:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (0) – Authentication is required, if enabled for the application.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (1) – Authentication is bypassed.  
  
 **Remarks**: Only one <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be present for a given logical request on the server. Each incoming request to one of the in-built LightSwitch server endpoints has its own <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> automatically created for the lifetime of the request. If you try to create a second <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> when one is already present, a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> will occur.  
  
 If authentication is enabled for your LightSwitch application,  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> tries to enforce user authentication. Specifically, if in your web.config file the **Authentication** mode is **Windows** or **Forms**, when your code tries to create a new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, if there isn't a valid authenticated user already on the **HttpContext**, your call to **CreateContext** will throw an exception.  
  
 If you don’t want this behavior, you can tell **CreateContext** to skip the authentication check, by setting the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  If you use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> option, creating and using the context will succeed without first establishing the identity of the user.  The lifetime of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is limited to just the code inside the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block. If you're using the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> option, don't write security sensitive code inside the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
###  \<a name="application">\</a> Application  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 Gets the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object for ththe LightSwitch application. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object provides access to active screens, methods of open screens, and access to the current user.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
###  \<a name="current">\</a> Current  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 Returns the currently in-scope <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if one exists; otherwise returns a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 **Remarks**: The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> property can be used instead of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method when accessing the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> from a server method such as <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. If you attempt to call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> from a server method, a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> will occur.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
###  \<a name="dataworkspace">\</a> DataWorkspace  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 Gets the containing data workspace. The data workspace provides access to all data sources in the application.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [Walkthrough: Inserting Data with the ServerApplicationContext](../vs140/walkthrough--inserting-data-with-the-serverapplicationcontext.md)   
 [LightSwitch ServerApplicationContext](../vs140/lightswitch-serverapplicationcontext.md)