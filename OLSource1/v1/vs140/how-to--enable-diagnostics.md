---
title: "How to: Enable Diagnostics"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ls.EnableDiagnostics"
helpviewer_keywords: 
  - "Visual Studio LightSwitch, diagnostics"
  - "diagnostics [Visual Studio LightSwitch]"
ms.assetid: 93900c8c-493c-489e-a11e-334818d194a4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Enable Diagnostics
You can find and fix errors that occur in the code that you write by debugging your application. There are, however, errors that can occur outside the code that you write. For example, there are many issues that could prevent your application from communicating with a server. To find and fix these types of errors, LightSwitch provides diagnostic capabilities both at design time and for a deployed application. Diagnostics is accomplished by enabling tracing on the client or on the server.  
  
> [!IMPORTANT]
>  When tracing is enabled for a LightSwitch application, trace information might appear on any browser that makes a request for the application from the server. Tracing is a security threat because it displays sensitive information, such as the values of server variables. Disable tracing for the application before you publish it to a production server.  
  
### To enable client tracing at design time  
  
1.  In **Solution Explorer**, open the shortcut menu for the **My Project** node and choose **Open**.  
  
    > [!NOTE]
    >  For HTML Client applications, skip to step 3.  
  
2.  In the Application Designer, choose the **Edit DesktopClient properties** link, choose the **Client Type** tab, and then choose the **Web** option.  
  
3.  On the menu bar, choose **View**, **Output** to display the **Output** window.  
  
4.  On the menu bar, choose **Debug**,**Start Debugging**.  
  
5.  In the address bar of the browser, add client tracing arguments to the end of the URL as follows:  
  
    -   To display an error-level trace, enter `LC=Microsoft.LightSwitch,E`.  
  
    -   To display a warning-level trace, enter `LC=Microsoft.LightSwitch,W`.  
  
    -   To display an information-level trace, enter `LC=Microsoft.LightSwitch,I`.  
  
    -   To display a verbose trace, enter `LC=Microsoft.LightSwitch,V`.  
  
     For example, following is the full URL for a verbose trace for an application named myapp.  
  
    ```  
    http://myapp/default.htm?LC=Microsoft.LightSwitch,V  
    ```  
  
     The application restarts and trace messages appear in the **Output** window.  
  
### To enable server tracing at design time  
  
1.  In **Solution Explorer**, expand the **Server** node, and the open the shortcut menu for the `Web.config` node and choose Open..  
  
2.  In the **<appSettings\>** section, find the line `<add key=”Microsoft.LightSwitch.Trace.Enabled” value=”false” />` and change `false` to `true`.  
  
3.  Close the **Web.config** file, and when you are prompted to save changes choose **Yes**.  
  
4.  In **Solution Explorer**, opem the shortcut menu for the **My Project** node and choose **Open**.  
  
5.  In the Application Designer, choose the **Client Type** tab, and then choose the **Web** option..  
  
6.  Run the application. The application will open in your default Web browser.  
  
7.  Copy the first part of the URL from the **Address Bar** of the browser. It should resemble **http://localhost:12345**, but with a different numeric value.  
  
8.  Open a new Web browser window or tab, and in the **Address Bar** paste the URL that you copied, and then enter `/Trace.axd`. It should resemble **http://localhost:12345/Trace.axd.**  
  
     This will display trace information for server operations.  
  
### To enable client tracing for a deployed 3-tier Web application  
  
1.  Open a Web browser and navigate to the URL for the application.  
  
2.  In the address bar of the browser, add client tracing arguments to the end of the URL as follows:  
  
    -   To display an error-level trace, enter `LC=Microsoft.LightSwitch,E`.  
  
    -   To display a warning-level trace, enter `LC=Microsoft.LightSwitch,W`.  
  
    -   To display an information-level trace, enter `LC=Microsoft.LightSwitch,I`.  
  
    -   To display a verbose trace, enter `LC=Microsoft.LightSwitch,V`.  
  
     For example, following is the full URL for a verbose trace for an application named myapp.  
  
    ```  
    http://myapp/default.htm?LC=Microsoft.LightSwitch,V  
    ```  
  
3.  View the trace messages in a debug viewer. Any debug viewer that can listen to debug output messages can be used to view LightSwitch trace messages.