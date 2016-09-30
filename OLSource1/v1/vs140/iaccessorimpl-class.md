---
title: "IAccessorImpl Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IAccessorImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAccessorImpl class"
ms.assetid: 768606da-8b71-417c-a62c-88069ce7730d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAccessorImpl Class
Provides an implementation of the [IAccessor](https://msdn.microsoft.com/en-us/library/ms719672.aspx) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Your rowset or command object class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage unit for binding information. The default is the **ATLBINDINGS** structure (see atldb.h).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Storage unit for column information. The default is [CAtlMap](../vs140/catlmap-class.md) where the key element is an **HACCESSOR** value and the value element is a pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[IAccessorImpl](../vs140/iaccessorimpl-class.md)|The constructor.|  
  
### Interface Methods  
  
|||  
|-|-|  
|[AddRefAccessor](../vs140/iaccessorimpl--addrefaccessor.md)|Adds a reference count to an existing accessor.|  
|[CreateAccessor](../vs140/iaccessorimpl--createaccessor.md)|Creates an accessor from a set of bindings.|  
|[GetBindings](../vs140/iaccessorimpl--getbindings.md)|Returns the bindings in an accessor.|  
|[ReleaseAccessor](../vs140/iaccessorimpl--releaseaccessor.md)|Releases an accessor.|  
  
## Remarks  
 This is mandatory on rowsets and commands. OLE DB requires providers to implement an **HACCESSOR**, which is a tag to an array of [DBBINDING](https://msdn.microsoft.com/en-us/library/ms716845.aspx) structures. **HACCESSOR**s provided by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are addresses of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structures. By default, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is defined as an **ATLBINDINGS** in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>'s template definition. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> provides a mechanism used by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to track the number of elements in its **DBBINDING** array as well as a reference count and accessor flags.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)