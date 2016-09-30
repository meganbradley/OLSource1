---
title: "CDataPathProperty::CDataPathProperty"
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
  - "CDataPathProperty.CDataPathProperty"
  - "CDataPathProperty::CDataPathProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataPathProperty class, constructor"
ms.assetid: 89d12cb8-e6a2-4216-8556-67c62273928b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::CDataPathProperty
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the OLE control object to be associated with this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object for a file, prepend <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the path.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used by **Open** and retrieved by derived classes. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **NULL**, the control used with **Open** should be set with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **NULL**, you can pass in the path through **Open** or set it with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::Open](../vs140/cdatapathproperty--open.md)   
 [CDataPathProperty::SetControl](../vs140/cdatapathproperty--setcontrol.md)