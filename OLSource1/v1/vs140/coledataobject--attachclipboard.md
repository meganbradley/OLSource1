---
title: "COleDataObject::AttachClipboard"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDataObject.AttachClipboard"
  - "COleDataObject::AttachClipboard"
  - "AttachClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataObject class, operations"
  - "AttachClipboard method"
ms.assetid: 0eef77f9-94bd-4523-96f2-254caffdc53a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::AttachClipboard
Call this function to attach the data object that is currently on the Clipboard to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
  
> [!NOTE]
>  Calling this function locks the Clipboard until this data object is released. The data object is released in the destructor for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [OpenClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649048) and [CloseClipboard](http://msdn.microsoft.com/library/windows/desktop/ms649035) in the Win32 documention.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::Attach](../vs140/coledataobject--attach.md)   
 [COleDataObject::Detach](../vs140/coledataobject--detach.md)   
 [COleDataObject::Release](../vs140/coledataobject--release.md)