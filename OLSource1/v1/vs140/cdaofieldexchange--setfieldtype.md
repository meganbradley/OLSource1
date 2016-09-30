---
title: "CDaoFieldExchange::SetFieldType"
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
  - "CDaoFieldExchange.SetFieldType"
  - "CDaoFieldExchange::SetFieldType"
  - "SetFieldType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Param field type"
  - "DFX (DAO record field exchange), field type outputColumn"
  - "SetFieldType method"
  - "DFX (DAO record field exchange)"
  - "DFX field types"
  - "enum FieldType, CDaoFieldExchange"
  - "FieldType enumeration"
  - "DFX (DAO record field exchange), field type param"
  - "fields [C++], types"
  - "DAO (Data Access Objects), field exchange"
ms.assetid: 20454687-582e-4a2c-96dd-6d6444468287
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoFieldExchange::SetFieldType
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> override.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value of the **enum FieldType**, declared in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which can be either of the following:  
  
-   **CDaoFieldExchange::outputColumn**  
  
-   **CDaoFieldExchange::param**  
  
## Remarks  
 Normally, ClassWizard writes this call for you. If you write your own function and are using the wizard to write your <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, add calls to your own function outside the field map. If you do not use the wizard, there will not be a field map. The call precedes calls to DFX functions, one for each field data member of your class, and identifies the field type as **CDaoFieldExchange::outputColumn**.  
  
 If you parameterize your recordset class, you should add DFX calls for all parameter data members (outside the field map) and precede these calls with a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Pass the value **CDaoFieldExchange::param**. (You can, instead, use a [CDaoQueryDef](../vs140/cdaoquerydef-class.md) and set its parameter values.)  
  
 In general, each group of DFX function calls associated with field data members or parameter data members must be preceded by a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter of each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> call identifies the type of the data members represented by the DFX function calls that follow the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> call.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoFieldExchange Class](../vs140/cdaofieldexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoFieldExchange::IsValidOperation](../vs140/cdaofieldexchange--isvalidoperation.md)   
 [CDaoRecordset::DoFieldExchange](../vs140/cdaorecordset--dofieldexchange.md)