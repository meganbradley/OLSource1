---
title: "CPropExchange::ExchangeBlobProp"
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
  - "CPropExchange::ExchangeBlobProp"
  - "ExchangeBlobProp"
  - "CPropExchange.ExchangeBlobProp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropExchange class, operations"
  - "ExchangeBlobProp method"
ms.assetid: d57153ae-c48a-44ed-a2a2-8300b95e5146
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropExchange::ExchangeBlobProp
Serializes a property that stores binary large object (BLOB) data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a variable pointing to where the property is stored (variable is typically a member of your class).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to, as appropriate, the variable referenced by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization fails.  
  
 The functions **CArchivePropExchange::ExchangeBlobProp**, **CResetPropExchange::ExchangeBlobProp**, and **CPropsetPropExchange::ExchangeBlobProp** override this pure virtual function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CPropExchange Class](../vs140/cpropexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [CPropExchange::ExchangeFontProp](../vs140/cpropexchange--exchangefontprop.md)   
 [CPropExchange::ExchangePersistentProp](../vs140/cpropexchange--exchangepersistentprop.md)   
 [CPropExchange::ExchangeProp](../vs140/cpropexchange--exchangeprop.md)