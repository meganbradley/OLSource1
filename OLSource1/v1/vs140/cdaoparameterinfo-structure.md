---
title: "CDaoParameterInfo Structure"
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
  - "CDaoParameterInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoParameterInfo structure"
  - "DAO (Data Access Objects), Parameters collection"
ms.assetid: 45fd53cd-cb84-4e12-b48d-7f2979f898ad
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoParameterInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a parameter object defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Uniquely names the parameter object. For more information, see the topic "Name Property" in DAO Help.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value that indicates the data type of a parameter object. For a list of the possible values, see the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member of the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. For more information, see the topic "Type Property" in DAO Help.  
  
 *m_varValue*  
 The value of the parameter, stored in a [COleVariant](../vs140/colevariant-class.md) object.  
  
## Remarks  
 The references to Primary and Secondary above indicate how the information is returned by the [GetParameterInfo](../vs140/cdaoquerydef--getparameterinfo.md) member function in class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 MFC does not encapsulate DAO parameter objects in a class. DAO querydef objects underlying MFC <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects store parameters in their Parameters collections. To access the parameter objects in a [CDaoQueryDef](../vs140/cdaoquerydef-class.md) object, call the querydef object's <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function for a particular parameter name or an index into the Parameters collection. You can use the [CDaoQueryDef::GetParameterCount](../vs140/cdaoquerydef--getparametercount.md) member function in conjunction with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to loop through the Parameters collection.  
  
 Information retrieved by the [CDaoQueryDef::GetParameterInfo](../vs140/cdaoquerydef--getparameterinfo.md) member function is stored in a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure. Call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for the querydef object in whose Parameters collection the parameter object is stored.  
  
> [!NOTE]
>  If you want to get or set only the value of a parameter, use the [GetParamValue](../vs140/cdaorecordset--getparamvalue.md) and [SetParamValue](../vs140/cdaorecordset--setparamvalue.md) member functions of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)