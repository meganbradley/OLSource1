---
title: "CDBPropSet::AddProperty"
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
  - "CDBPropSet::AddProperty"
  - "CDBPropSet.AddProperty"
  - "AddProperty"
  - "ATL::CDBPropSet::AddProperty"
  - "ATL.CDBPropSet.AddProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddProperty method"
ms.assetid: dc9539d3-1ee4-40f3-9281-2068e6d65e93
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBPropSet::AddProperty
Adds a property to the property set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwPropertyID*  
 [in] The ID of the property to be added. Used to initialize the **dwPropertyID** of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A variant used to initialize the property value for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A string used to initialize the property value for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A **BYTE** or boolean value used to initialize the property value for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] An integer value used to initialize the property value for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure added to the property set.  
  
 *fltValue*  
 [in] A floating-point value used to initialize the property value for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] A double-precision floating-point value used to initialize the property value for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure added to the property set.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] A CY currency value used to initialize the property value for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure added to the property set.  
  
## Return Value  
 **true** if the property was successfully added. Otherwise, **false**.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDBPropSet Class](../vs140/cdbpropset-class.md)   
 [DBPROP Structure](https://msdn.microsoft.com/en-us/library/ms717970.aspx)