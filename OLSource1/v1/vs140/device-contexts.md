---
title: "Device Contexts"
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
  - "OnPrepareDC method"
  - "windows [C++], and device context"
  - "drawing, device context"
  - "CClientDC class, and GetDC method"
  - "drawing, in mouse and device contexts"
  - "CDC class, objects"
  - "device contexts [C++]"
  - "client areas"
  - "CMetaFileDC class, and OnPrepareDC method"
  - "GDI objects [C++], device contexts"
  - "graphic objects, device contexts"
  - "frame windows [C++], device contexts"
  - "metafiles and device contexts"
  - "EndPaint method"
  - "printers [C++], device contexts"
  - "mouse [C++], drawing and device contexts"
  - "BeginPaint method, CPaintDC"
  - "CPaintDC class, device context for painting"
  - "windows [C++], drawing directly into"
  - "client areas, and device context"
  - "device contexts [C++], CDC class"
  - "user interface [C++], device contexts"
  - "device-independent drawing"
  - "GetDC method and CClientDC class"
  - "CClientDC class, and ReleaseDC method"
  - "ReleaseDC method"
  - "device contexts [C++], about device contexts"
  - "drawing, directly into windows"
  - "painting and device context"
ms.assetid: d0cd51f1-f778-4c7e-bf50-d738d10433c7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Device Contexts
A device context is a Windows data structure containing information about the drawing attributes of a device such as a display or a printer. All drawing calls are made through a device-context object, which encapsulates the Windows APIs for drawing lines, shapes, and text. Device contexts allow device-independent drawing in Windows. Device contexts can be used to draw to the screen, to the printer, or to a metafile.  
  
 [CPaintDC](../vs140/cpaintdc-class.md) objects encapsulate the common idiom of Windows, calling the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function, then drawing in the device context, then calling the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> constructor calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for you, and the destructor calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The simplified process is to create the [CDC](../vs140/cdc-class.md) object, draw, and then destroy the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. In the framework, much of even this process is automated. In particular, your <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function is passed a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> already prepared (via <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), and you simply draw into it. It is destroyed by the framework and the underlying device context is released to Windows upon return from the call to your <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function.  
  
 [CClientDC](../vs140/cclientdc-class.md) objects encapsulate working with a device context that represents only the client area of a window. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> constructor calls the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, and the destructor calls the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function. [CWindowDC](../vs140/cwindowdc-class.md) objects encapsulate a device context that represents the whole window, including its frame.  
  
 [CMetaFileDC](../vs140/cmetafiledc-class.md) objects encapsulate drawing into a Windows metafile. In contrast to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> passed to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, you must in this case call [OnPrepareDC](../vs140/cview--onpreparedc.md) yourself.  
  
## Mouse Drawing  
 Most drawing in a framework program — and thus most device-context work — is done in the view's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member function. However, you can still use device-context objects for other purposes. For example, to provide tracking feedback for mouse movement in a view, you need to draw directly into the view without waiting for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to be called.  
  
 In such a case, you can use a [CClientDC](../vs140/cclientdc-class.md) device-context object to draw directly into the view.  
  
### What do you want to know more about?  
  
-   [Device contexts (definition)](http://msdn.microsoft.com/library/windows/desktop/dd183553)  
  
-   [Drawing in a View](../vs140/drawing-in-a-view.md)  
  
-   [Interpreting User Input Through a View](../vs140/interpreting-user-input-through-a-view.md)  
  
-   [Lines and curves](http://msdn.microsoft.com/library/windows/desktop/dd145028)  
  
-   [Filled shapes](http://msdn.microsoft.com/library/windows/desktop/dd162714)  
  
-   [Fonts and text](http://msdn.microsoft.com/library/windows/desktop/dd144819)  
  
-   [Colors](http://msdn.microsoft.com/library/windows/desktop/dd183450)  
  
-   [Coordinate spaces and transformations](http://msdn.microsoft.com/library/windows/desktop/dd183475)  
  
## See Also  
 [Window Objects](../vs140/window-objects.md)