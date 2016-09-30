---
title: "IRowsetCreatorImpl Class"
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
  - "ATL::IRowsetCreatorImpl"
  - "ATL.IRowsetCreatorImpl"
  - "ATL::IRowsetCreatorImpl<T>"
  - "ATL.IRowsetCreatorImpl<T>"
  - "IRowsetCreatorImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IRowsetCreatorImpl class"
ms.assetid: 92cc950f-7978-4754-8d9a-defa63867d82
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetCreatorImpl Class
Performs the same functions as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> but also enables the OLE DB properties **DBPROPCANSCROLLBACKWARDS DBPROPCANFETCHBACKWARDS**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A class derived from **IRowsetCreator**.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[SetSite](../vs140/irowsetcreatorimpl--setsite.md)|Sets the site that contains the rowset object.|  
  
## Remarks  
 This class inherits from [IObjectWithSite](http://msdn.microsoft.com/library/windows/desktop/ms693765) and overrides [IObjectWithSite::SetSite](http://msdn.microsoft.com/library/windows/desktop/ms683869). When a provider command or session object creates a rowset, it calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on the rowset object looking for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> passing the rowset object's **IUnkown** interface as the site interface.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)