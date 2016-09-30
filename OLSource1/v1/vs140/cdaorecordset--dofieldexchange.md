---
title: "CDaoRecordset::DoFieldExchange"
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
  - "CDaoRecordset.DoFieldExchange"
  - "CDaoRecordset::DoFieldExchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, field exchange"
  - "DoFieldExchange method"
  - "CDaoRecordset class, field exchange"
ms.assetid: fc578a26-82c6-4d07-b331-705d8d716762
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::DoFieldExchange
The framework calls this member function to automatically exchange data between the field data members of your recordset object and the corresponding columns of the current record on the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains a pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. The framework will already have set up this object to specify a context for the field exchange operation.  
  
## Remarks  
 It also binds your parameter data members, if any, to parameter placeholders in the SQL statement string for the recordset's selection. The exchange of field data, called DAO record field exchange (DFX), works in both directions: from the recordset object's field data members to the fields of the record on the data source, and from the record on the data source to the recordset object. If you are binding columns dynamically, you are not required to implement <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The only action you must normally take to implement <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for your derived recordset class is to create the class with ClassWizard and specify the names and data types of the field data members. You might also add code to what ClassWizard writes to specify parameter data members. If all fields are to be bound dynamically, this function will be inactive unless you specify parameter data members.  
  
 When you declare your derived recordset class with ClassWizard, the wizard writes an override of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for you, which resembles the following example:  
  
 [!code[NVC_MFCDatabase#2](../vs140/codesnippet/CPP/cdaorecordset--dofieldexchange_1.cpp)]  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoException Class](../vs140/cdaoexception-class.md)