---
title: "Referencing a Property in Your Provider"
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
  - "OLE DB providers, properties"
  - "references, to properties in providers"
  - "referencing properties in providers"
ms.assetid: bfbb3851-5eed-467a-a179-4a97a9515525
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Referencing a Property in Your Provider
Find the property group and property ID for the property you want. For more information, see [OLE DB Properties](https://msdn.microsoft.com/en-us/library/ms722734.aspx) in the *OLE DB Programmer's Reference*.  
  
 The following example assumes that you are trying to get a property from the rowset. The code for using the session or command is similar, but uses a different interface.  
  
 Create a [CDBPropSet](../vs140/cdbpropset-class.md) object using the property group as the parameter to the constructor. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Call [AddProperty](../vs140/cdbpropset--addproperty.md), passing it the property ID and a value to be assigned to the property. The type of the value depends on the property you are using.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface to call **GetProperties**. Pass the property set as a parameter. Here is the final code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Working with OLE DB Provider Templates](../vs140/working-with-ole-db-provider-templates.md)