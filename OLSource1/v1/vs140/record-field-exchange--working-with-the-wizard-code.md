---
title: "Record Field Exchange: Working with the Wizard Code"
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
  - "DoFieldExchange method, overriding"
  - "Unicode, with database classes"
  - "field data members, declaring"
  - "RFX (ODBC), wizard code"
  - "RFX (ODBC), implementing"
  - "field data members"
  - "ODBC, RFX"
  - "m_nParams data member, initializing"
  - "m_nFields data member"
  - "m_nParams data member"
  - "overriding, DoFieldExchange"
  - "m_nFields data member, initializing"
ms.assetid: f00d882a-ff1b-4a75-9717-98d8762bb237
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record Field Exchange: Working with the Wizard Code
This topic explains the code that the MFC Application Wizard and **Add Class** (as described in [Adding an MFC ODBC Consumer](../vs140/adding-an-mfc-odbc-consumer.md)) write to support RFX and how you might want to alter that code.  
  
> [!NOTE]
>  This topic applies to classes derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in which bulk row fetching has not been implemented. If you are using bulk row fetching, bulk record field exchange (Bulk RFX) is implemented. Bulk RFX is similar to RFX. To understand the differences, see [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 When you create a recordset class with the MFC Application Wizard or **Add Class**, the wizard writes the following RFX-related elements for you, based on the data source, table, and column choices you make in the wizard:  
  
-   Declarations of the recordset field data members in the recordset class  
  
-   An override of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   Initialization of recordset field data members in the recordset class constructor  
  
##  \<a name="_core_the_field_data_member_declarations">\</a> Field Data Member Declarations  
 The wizards write a recordset class declaration in an .h file that resembles the following for class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you add parameter data members or new field data members that you bind yourself, add them after the wizard-generated ones.  
  
 Also, notice that the wizard overrides the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
##  \<a name="_core_the_dofieldexchange_override">\</a> DoFieldExchange Override  
 [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) is the heart of RFX. The framework calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> any time it needs to move data either from data source to recordset or from recordset to data source. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> also supports obtaining information about field data members through the [IsFieldDirty](../vs140/crecordset--isfielddirty.md) and [IsFieldNull](../vs140/crecordset--isfieldnull.md) member functions.  
  
 The following <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> override is for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class. The wizard writes the function in the .cpp file for your recordset class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice the following key features of the function:  
  
-   This section of the function is called the field map.  
  
-   A call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, through the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer. This call specifies that all RFX function calls up to the end of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or the next call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are output columns. For more information, see [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md).  
  
-   Several calls to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> global function — one per field data member (all of which are <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> variables in the example). These calls specify the relationship between a column name on the data source and a field data member. The RFX functions do the actual data transfer. The class library supplies RFX functions for all the common data types. For more information about RFX functions, see [Record Field Exchange: Using the RFX Functions](../vs140/record-field-exchange--using-the-rfx-functions.md).  
  
    > [!NOTE]
    >  The order of the columns in your result set must match the order of the RFX function calls in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object that the framework passes when it calls <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object specifies the operation that <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is to perform, the direction of transfer, and other context information.  
  
##  \<a name="_core_the_recordset_constructor">\</a> Recordset Constructor  
 The recordset constructor that the wizards write contains two things related to RFX:  
  
-   An initialization for each field data member  
  
-   An initialization for the [m_nFields](../vs140/crecordset--m_nfields.md) data member, which contains the number of field data members  
  
 The constructor for the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> recordset example looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!NOTE]
>  If you add any field data members manually, as you might if you bind new columns dynamically, you must increment <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Do so by appending another line of code, such as:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This is the code for adding three new fields. If you add any parameter data members, you must initialize the [m_nParams](../vs140/crecordset--m_nparams.md) data member, which contains the number of parameter data members. Put the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> initialization outside the brackets.  
  
## See Also  
 [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md)