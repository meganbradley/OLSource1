---
title: "CRowsetImpl Class"
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
  - "CRowsetImpl"
  - "ATL.CRowsetImpl"
  - "ATL::CRowsetImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRowsetImpl class"
ms.assetid: e97614b3-b11d-4806-a0d3-b9401331473f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowsetImpl Class
Provides a standard OLE DB rowset implementation without requiring multiple inheritance of many implementation interfaces.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The user's class that derives from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The user record class.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The class that contains properties for the rowset; typically the command.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The class that will act as storage for the rowset's data. This parameter defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, but it can be any class that supports the required functionality.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[NameFromDBID](../vs140/crowsetimpl--namefromdbid.md)|Extracts a string from a **DBID** and copies it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> passed in.|  
|[SetCommandText](../vs140/crowsetimpl--setcommandtext.md)|Validates and stores the **DBID**s in the two strings ([m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md) and [m_strIndexText](../vs140/crowsetimpl--m_strindextext.md)).|  
  
### Overridable Methods  
  
|||  
|-|-|  
|[GetColumnInfo](../vs140/crowsetimpl--getcolumninfo.md)|Retrieves column information for a particular client request.|  
|[GetCommandFromID](../vs140/crowsetimpl--getcommandfromid.md)|Checks to see if either or both parameters contain string values, and if so, copies the string values to the data members [m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md) and [m_strIndexText](../vs140/crowsetimpl--m_strindextext.md).|  
|[ValidateCommandID](../vs140/crowsetimpl--validatecommandid.md)|Checks to see if either or both **DBID**s contain string values, and if so, copies them to its data members [m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md) and [m_strIndexText](../vs140/crowsetimpl--m_strindextext.md).|  
  
### Data Members  
  
|||  
|-|-|  
|[m_rgRowData](../vs140/crowsetimpl--m_rgrowdata.md)|By default, a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that templatizes on the user record template argument to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Another array type class can be used by changing the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> template argument to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md)|Contains the rowset's initial command.|  
|[m_strIndexText](../vs140/crowsetimpl--m_strindextext.md)|Contains the rowset's initial index.|  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> provides overrides in the form of static upcasts. The methods control the manner in which a given rowset will validate command text. You can create your own <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-style class by making your implementation interfaces multiple-inherited. The only method for which you must provide implementation is **Execute**. Depending on what type of rowset you are creating, the creator methods will expect different signatures for **Execute**. For example, if you are using a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>-derived class to implement a schema rowset, the **Execute** method will have the following signature:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 If you are creating a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived class to implement a command or session's rowset, the **Execute** method will have the following signature:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 To implement any of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>-derived **Execute** methods, you must populate your internal data buffers ([m_rgRowData](../vs140/crowsetimpl--m_rgrowdata.md)).  
  
## Requirements  
 **Header:** atldb.h