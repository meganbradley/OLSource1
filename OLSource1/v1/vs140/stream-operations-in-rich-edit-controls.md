---
title: "Stream Operations in Rich Edit Controls"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - CRichEditCtrl class, stream operations
  - CRichEditCtrl class, stream storage
  - rich edit controls, stream operations
  - storage, stream in CRichEditCtrl
  - stream operations in CRichEditCtrl
  - stream storage and CRichEditCtrl
ms.assetid: 110b4684-1e76-4ca6-9ef0-5bc8b2d93c78
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Stream Operations in Rich Edit Controls
You can use streams to transfer data into or out of a rich edit control ([CRichEditCtrl](../vs140/cricheditctrl-class.md)). A stream is defined by an [EDITSTREAM](http://msdn.microsoft.com/library/windows/desktop/bb787891) structure, which specifies a buffer and an application-defined callback function.  
  
 To read data into a rich edit control (that is, stream the data in), use the [StreamIn](../vs140/cricheditctrl--streamin.md) member function. The control repeatedly calls the application-defined callback function, which transfers a portion of the data into the buffer each time.  
  
 To save the contents of a rich edit control (that is, stream the data out), you can use the [StreamOut](../vs140/cricheditctrl--streamout.md) member function. The control repeatedly writes to the buffer and then calls the application-defined callback function. For each call, the callback function saves the contents of the buffer.  
  
## See Also  
 [Using CRichEditCtrl](../vs140/using-cricheditctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)