---
title: "CRowset::SetData"
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
  - "ATL.CRowset<TAccessor>.SetData"
  - "SetData"
  - "ATL::CRowset::SetData"
  - "CRowset<TAccessor>.SetData"
  - "CRowset::SetData"
  - "ATL.CRowset.SetData"
  - "CRowset.SetData"
  - "CRowset<TAccessor>::SetData"
  - "ATL::CRowset<TAccessor>::SetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetData method"
ms.assetid: 68125142-8510-4132-9393-e39efd39c784
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::SetData
Sets data values in one or more columns of a row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of the accessor to use for accessing the data.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 For the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> form that accepts no arguments, all accessors are used for updating. You typically call **SetData** to set data values in columns in a row, then call [Update](../vs140/crowset--update.md) to transmit those changes.  
  
 This method requires the optional interface <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetChange** to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before calling **Open** on the table or command containing the rowset.  
  
 The setting operation might fail if one or more columns is not writable. Modify your cursor map to correct this.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [CRowset::Update](../vs140/crowset--update.md)