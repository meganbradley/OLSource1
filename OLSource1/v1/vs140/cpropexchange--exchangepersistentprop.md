---
title: "CPropExchange::ExchangePersistentProp"
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
  - "ExchangePersistentProp"
  - "CPropExchange::ExchangePersistentProp"
  - "CPropExchange.ExchangePersistentProp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropExchange class, operations"
  - "ExchangePersistentProp method"
ms.assetid: 2d484797-bdd6-40cb-a148-9ff32d3e21b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropExchange::ExchangePersistentProp
Exchanges a property between the control and a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a variable containing a pointer to the property's **IUnknown** interface (this variable is typically a member of your class).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Interface ID of the interface on the property that the control will use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 If the property is being loaded from the file to the control, the property is created and initialized from the file. If the property is being stored, its value is written to the file.  
  
 The functions **CArchivePropExchange::ExchangePersistentProp**, **CResetPropExchange::ExchangePersistentProp**, and **CPropsetPropExchange::ExchangePersistentProp** override this pure virtual function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CPropExchange Class](../vs140/cpropexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [CPropExchange::ExchangeBlobProp](../vs140/cpropexchange--exchangeblobprop.md)   
 [CPropExchange::ExchangeFontProp](../vs140/cpropexchange--exchangefontprop.md)   
 [CPropExchange::ExchangeProp](../vs140/cpropexchange--exchangeprop.md)