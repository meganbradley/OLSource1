---
title: "COleDataObject::Release"
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
  - "COleDataObject::Release"
  - "COleDataObject.Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
  - "COleDataObject class, operations"
ms.assetid: 1ee76d0b-75b3-4d32-9646-6650779275ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataObject::Release
Call this function to release ownership of the [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) object that was previously associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> was associated with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> by calling **Attach** or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> explicitly or by the framework. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of **Attach** is **FALSE**, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object will not be released. In this case, the caller is responsible for releasing the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> by calling [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject::Attach](../vs140/coledataobject--attach.md)   
 [COleDataObject::COleDataObject](../vs140/coledataobject--coledataobject.md)   
 [COleDataObject::Detach](../vs140/coledataobject--detach.md)