---
title: "WinInet Basics"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStatusCallback method"
  - "WinInet classes, displaying progress"
  - "WinInet classes, about WinInet classes"
ms.assetid: 665de5ac-e80d-427d-8d91-2ae466885940
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WinInet Basics
You can use WinInet to add FTP support to download and upload files from within your application. You can override [OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) and use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter to provide progress information to users as you search for and download files.  
  
 This article contains the following topics:  
  
-   [Create a Very Simple Browser](#_core_create_a_very_simple_browser)  
  
-   [Download a Web Page](#_core_download_a_web_page)  
  
-   [FTP a File](#_core_ftp_a_file)  
  
-   [Retrieve a Gopher Directory](#_core_retrieve_a_gopher_directory)  
  
-   [Display Progress Information While Transferring Files](#_core_display_progress_information_while_transferring_files)  
  
 The code excerpts below demonstrate how to create a simple browser, download a Web page, FTP a file, and search for a gopher file. They are not meant as complete examples and not all contain exception handling.  
  
 For additional information on WinInet, see [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md).  
  
##  \<a name="_core_create_a_very_simple_browser">\</a> Create a Very Simple Browser  
 [!code[NVC_MFCWinInet#1](../vs140/codesnippet/CPP/wininet-basics_1.cpp)]  
  
##  \<a name="_core_download_a_web_page">\</a> Download a Web Page  
 [!code[NVC_MFCWinInet#2](../vs140/codesnippet/CPP/wininet-basics_2.cpp)]  
  
##  \<a name="_core_ftp_a_file">\</a> FTP a File  
 [!code[NVC_MFCWinInet#3](../vs140/codesnippet/CPP/wininet-basics_3.cpp)]  
  
##  \<a name="_core_retrieve_a_gopher_directory">\</a> Retrieve a Gopher Directory  
 [!code[NVC_MFCWinInet#4](../vs140/codesnippet/CPP/wininet-basics_4.cpp)]  
  
## Use OnStatusCallback  
 When using the WinInet classes, you can use the [OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) member of your application's [CInternetSession](../vs140/cinternetsession-class.md) object to retrieve status information. If you derive your own <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, override <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and enable status callbacks, MFC will call your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function with progress information about all the activity in that Internet session.  
  
 Because a single session might support several connections (which, over their lifetime, might perform many different distinct operations), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> needs a mechanism to identify each status change with a particular connection or transaction. That mechanism is provided by the context ID parameter given to many of the member functions in the WinInet support classes. This parameter is always of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and is always named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The context assigned to a particular Internet object is used only to identify the activity the object causes in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. The call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> receives several parameters; these parameters work together to tell your application what progress has been made for which transaction and connection.  
  
 When you create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object, you can specify a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter to the constructor. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> itself doesn't use the context ID; instead, it passes the context ID on to any **InternetConnection**-derived objects that don't explicitly get a context ID of their own. In turn, those <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects will pass the context ID along to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects they create if you don't explicitly specify a different context ID. If, on the other hand, you do specify a specific context ID of your own, the object and any work it does will be associated with that context ID. You can use the context IDs to identify what status information is being given to you in your <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function.  
  
##  \<a name="_core_display_progress_information_while_transferring_files">\</a> Display Progress Information While Transferring Files  
 For example, if you write an application that creates a connection with an FTP server to read a file and also connects to an HTTP server to get a Web page, you'll have a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object, two <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects (one would be a **CFtpSession** and the other would be a **CHttpSession**), and two <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects (one for each connection). If you used default values for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameters, you would not be able to distinguish between the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> invocations that indicate progress for the FTP connection and the invocations that indicate progress for the HTTP connection. If you specify a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> ID, which you can later test for in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, you will know which operation generated the callback.  
  
## See Also  
 [MFC Internet Programming Basics](../vs140/mfc-internet-programming-basics.md)   
 [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md)