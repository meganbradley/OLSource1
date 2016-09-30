---
title: "CDataSource::Open"
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
  - "ATL::CDataSource::Open"
  - "ATL.CDataSource.Open"
  - "CDataSource::Open"
  - "CDataSource.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: a6d28bd1-799a-48ed-8993-5f82d1705b77
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource::Open
Opens a connection to a data source using a **CLSID**, **ProgID**, or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> moniker or prompts the user with a locator dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The **CLSID** of the data provider.  
  
 *pPropSet*  
 [in] A pointer to an array of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures containing properties and values to be set. See [Property Sets and Property Groups](https://msdn.microsoft.com/en-us/library/ms713696.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *nPropertySets*  
 [in] The number of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures passed in the *pPropSet* argument.  
  
 *pName*  
 [in] The name of the database to which to connect.  
  
 *pUserName*  
 [in] The name of the user.  
  
 *pPassword*  
 [in] The user's password.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Database initialization mode. See [Initialization Properties](https://msdn.microsoft.com/en-us/library/ms723127.aspx)in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of valid initialization modes. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, no initialization mode is included in the property set used to open the connection.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] A program identifier.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A [CEnumerator](../vs140/cenumerator-class.md) object used to obtain a moniker for opening the connection when the caller does not specify a **CLSID**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Handle to the window that is to be the parent of the dialog box. Using the function overload that uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter will automatically invoke Service Components; see Remarks for details.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] Determines the style of locator dialog box to display. See Msdasc.h for possible values.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The method overload that uses the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter opens a data source object with the service components in oledb32.dll; this DLL contains the implementation of Service Components features such as Resource Pooling, Automatic Transaction Enlistment, and so on. For more information, see "OLE DB Services" in the OLE DB Programmer's Reference at [http://msdn.microsoft.com/library/default.asp?url=/library/oledb/htm/oledbole_db_services.asp?frame=true](http://msdn.microsoft.com/library/default.asp?url=/library/oledb/htm/oledbole_db_services.asp?frame=true).  
  
 The method overloads that do not use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter open a data source object without using the service components in oledb32.dll. A [CDataSource](../vs140/cdatasource-class.md) object opened with these function overloads will be unable to utilize any of the functionality of Service Components.  
  
## Example  
 The following code shows how to open a Jet 4.0 data source with OLE DB Templates. You treat the Jet data source as an OLE DB data source. However, your call to **Open** needs two property sets: one for **DBPROPSET_DBINIT** and the other for **DBPROPSET_JETOLEDB_DBINIT**, so that you can set **DBPROP_JETOLEDB_DATABASEPASSWORD**.  
  
 [!code[NVC_OLEDB_Consumer#7](../vs140/codesnippet/CPP/cdatasource--open_1.cpp)]  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataSource Class](../vs140/cdatasource-class.md)