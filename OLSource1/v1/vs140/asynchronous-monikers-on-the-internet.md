---
title: "Asynchronous Monikers on the Internet"
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
  - "ActiveX controls [C++], asynchronous"
  - "MFC [C++], asynchronous monikers"
  - "asynchronous monikers [C++]"
  - "Web applications [C++], asynchronous"
  - "downloading Internet resources and asynchronous monikers"
  - "optimization [C++], asynchronous downloading across Internet"
  - "Internet [C++], asynchronous downloading"
ms.assetid: 418b0c64-0046-4dae-8118-c9c762b5822e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Asynchronous Monikers on the Internet
The Internet requires new approaches to application design because of its slow network access. Applications should perform network access asynchronously to avoid stalling the user interface. The MFC class [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md) provides asynchronous support for downloading files.  
  
 With asynchronous monikers, you can extend your COM application to download asynchronously across the Internet and to provide progressive rendering of large objects such as bitmaps and VRML objects. Asynchronous monikers enable an ActiveX control property or a file on the Internet to be downloaded without blocking the response of the user interface.  
  
## Advantages of Asynchronous Monikers  
 You can use asynchronous monikers to:  
  
-   Download code and files without blocking.  
  
-   Download properties in ActiveX controls without blocking.  
  
-   Receive notifications of downloading progress.  
  
-   Track progress and ready state information.  
  
-   Provide status information to the user about progress.  
  
-   Allow the user to cancel a download at any time.  
  
## MFC Classes for Asynchronous Monikers  
 [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md) is derived from [CMonikerFile](../vs140/cmonikerfile-class.md), which in turn is derived from [COleStreamFile](../vs140/colestreamfile-class.md). A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object represents a stream of data; a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object uses an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to obtain the data, and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object does so asynchronously.  
  
 Asynchronous monikers are used primarily in Internet-enabled applications and ActiveX controls to provide a responsive user interface during file transfers. A prime example of this is the use of [CDataPathProperty](../vs140/cdatapathproperty-class.md) to provide asynchronous properties for ActiveX controls.  
  
## MFC Classes for Data Paths in ActiveX Controls  
 The MFC classes <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and [CCachedDataPathProperty](../vs140/ccacheddatapathproperty-class.md) implement ActiveX control properties that can be loaded asynchronously. Asynchronous properties are loaded after synchronous initiation. Asynchronous ActiveX controls repeatedly invoke a callback to indicate availability of new data during a lengthy property exchange process.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. To implement asynchronous properties in your ActiveX controls, derive a class from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and override [OnDataAvailable](../vs140/casyncmonikerfile--ondataavailable.md) and other notifications you wish to receive.  
  
#### To download a file using asynchronous monikers  
  
1.  Declare a class derived from [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md).  
  
2.  Override [OnDataAvailable](../vs140/casyncmonikerfile--ondataavailable.md) to display the data.  
  
3.  Override other member functions, including [OnProgress](../vs140/casyncmonikerfile--onprogress.md), [OnStartBinding](../vs140/casyncmonikerfile--onstartbinding.md), and [OnStopBinding](../vs140/casyncmonikerfile--onstopbinding.md).  
  
4.  Declare an instance of this class and use it to open URLs.  
  
 For information about downloading asynchronously in an ActiveX control, see [ActiveX Controls on the Internet](../vs140/activex-controls-on-the-internet.md).  
  
## See Also  
 [MFC Internet Programming Tasks](../vs140/mfc-internet-programming-tasks.md)   
 [MFC Internet Programming Basics](../vs140/mfc-internet-programming-basics.md)