---
title: "Converting Data Not Supported by the Provider"
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
  - "OLE DB provider templates, unsupported data types"
ms.assetid: f495e50f-530a-4fab-ab54-e0c359785845
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Converting Data Not Supported by the Provider
When the consumer requests a data type that is not supported by the provider, the OLE DB provider template code for `IRowsetImpl::GetData` calls Msdadc.dll to convert the data type.  
  
 If you implement an interface like `IRowsetChange` that requires data conversion, you can call Msdaenum.dll to do the conversion. Use `GetData`, defined in Atldb.h, as an example.  
  
## See Also  
 [Working with OLE DB Provider Templates](../vs140/working-with-ole-db-provider-templates.md)