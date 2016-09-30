---
title: "CCachedDataPathProperty::CCachedDataPathProperty"
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
  - "CCachedDataPathProperty.CCachedDataPathProperty"
  - "CCachedDataPathProperty::CCachedDataPathProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCachedDataPathProperty class, constructor"
ms.assetid: a8bbb508-4f36-4175-a5fd-06524f500a95
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCachedDataPathProperty::CCachedDataPathProperty
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the ActiveX control object to be associated with this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object for a file, prepend file:// to the path.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used by [Open](../vs140/cdatapathproperty--open.md) and retrieved by derived classes. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **NULL**, the control used with **Open** should be set with [SetControl](../vs140/cdatapathproperty--setcontrol.md). If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **NULL**, you can pass in the path through **Open** or set it with [SetPath](../vs140/cdatapathproperty--setpath.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CCachedDataPathProperty Class](../vs140/ccacheddatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)