---
title: "Dragging and Dropping Files in a Frame Window"
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
  - "drag and drop [C++], files"
  - "drag and drop [C++], File Manager"
  - "Windows Explorer [C++]"
  - "File Manager drag and drop support"
  - "files [C++], drag and drop"
  - "frame windows [C++], dragging and dropping files in"
  - "drag and drop [C++], Windows Explorer"
ms.assetid: 85560fe9-121b-4105-bd7b-216b966e19fa
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dragging and Dropping Files in a Frame Window
The frame window manages a relationship with File Explorer or File Manager.  
  
 By adding a few initializing calls in your override of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, as described in [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md), you can have your frame window indirectly open files dragged from File Explorer or File Manager and dropped in the frame window. See [File Manager Drag and Drop](../vs140/special-cwinapp-services.md).  
  
## See Also  
 [Using Frame Windows](../vs140/using-frame-windows.md)