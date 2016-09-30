---
title: "CPropExchange::ExchangeProp"
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
  - "ExchangeProp"
  - "CPropExchange.ExchangeProp"
  - "CPropExchange::ExchangeProp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropExchange class, operations"
  - "ExchangeProp method"
ms.assetid: 7bc96006-3027-4c97-89e8-63b89878756c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropExchange::ExchangeProp
Exchanges a property between a storage medium and the control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A symbol specifying the type of the property being exchanged. Possible values are:  
  
|Symbol|Property Type|  
|------------|-------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|**BOOL**|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**double**|  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to the property's value.  
  
 *pvDefault*  
 Pointer to a default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 If the property is being loaded from the medium to the control, the property's value is retrieved from the medium and stored in the object pointed to by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the property is being stored to the medium, the value of the object pointed to by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is written to the medium.  
  
 The functions **CArchivePropExchange::ExchangeProp**, **CResetPropExchange::ExchangeProp**, and **CPropsetPropExchange::ExchangeProp** override this pure virtual function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CPropExchange Class](../vs140/cpropexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [CPropExchange::ExchangeBlobProp](../vs140/cpropexchange--exchangeblobprop.md)   
 [CPropExchange::ExchangeFontProp](../vs140/cpropexchange--exchangefontprop.md)   
 [CPropExchange::ExchangePersistentProp](../vs140/cpropexchange--exchangepersistentprop.md)