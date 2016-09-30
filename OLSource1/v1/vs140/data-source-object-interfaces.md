---
title: "Data Source Object Interfaces"
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
  - "data source objects [C++], interfaces"
  - "data source objects [C++]"
  - "interfaces [C++], OLE DB"
  - "interfaces [C++], list of"
  - "OLE DB provider templates [C++], object interfaces"
  - "OLE DB [C++], interfaces"
ms.assetid: 929e100c-c08c-4b64-8437-d8d1357226f6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Source Object Interfaces
The following table shows the mandatory and optional interfaces defined by OLE DB for a data source object.  
  
|Interface|Required?|Implemented by OLE DB templates?|  
|---------------|---------------|--------------------------------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Mandatory|Yes|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Mandatory|Yes|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Mandatory|Yes|  
|[IPersist](http://msdn.microsoft.com/library/windows/desktop/ms688695)|Mandatory|Yes|  
|[IConnectionPointContainer](http://msdn.microsoft.com/library/windows/desktop/ms683857)|Optional|No|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional|No|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional|No|  
|[IPersistFile](http://msdn.microsoft.com/library/windows/desktop/ms687223)|Optional|No|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional|No|  
  
 The data source object implements the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interfaces through inheritance. You can choose to support additional functionality by inheriting or not inheriting from one of these implementation classes. If you want to support the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface, you must inherit from the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class.  
  
## See Also  
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)