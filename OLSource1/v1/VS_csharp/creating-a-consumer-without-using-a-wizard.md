---
title: "Creating a Consumer Without Using a Wizard"
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
  - "OLE DB consumers, creating"
ms.assetid: e8241cfe-5faf-48f8-9de3-241203de020b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a Consumer Without Using a Wizard
The following example assumes that you are adding OLE DB consumer support to an existing ATL project. If you want to add OLE DB consumer support to an MFC application, you should run the MFC Application Wizard, which creates all the support necessary and invokes MFC routines necessary to execute the application.  
  
 To add OLE DB consumer support without using the ATL OLE DB Consumer Wizard:  
  
-   In your Stdafx.h file, append the following `#include` statements:  
  
    ```  
    #include <atlbase.h>  
    #include <atldbcli.h>  
    #include <atldbsch.h> // if you are using schema templates  
    ```  
  
 Programmatically, a consumer typically performs the following sequence of operations:  
  
-   Create a user record class that binds columns to local variables. In this example, `CMyTableNameAccessor` is the user record class (see [User Records](../VS_csharp/user-records.md)). This class contains the column map and parameter map. Declare a data member in the user record class for each field you specify in your column map; for each of these data members, also declare a status data member and a length data member. For more information, see [Field Status Data Members in Wizard-Generated Accessors](../VS_csharp/field-status-data-members-in-wizard-generated-accessors.md).  
  
    > [!NOTE]
    >  If you write your own consumer, the data variables must come before the status and length variables.  
  
-   Instantiate a data source and a session. Decide what type of accessor and rowset to use and then instantiate a rowset using [CCommand](../VS_csharp/ccommand-class.md) or [CTable](../VS_csharp/ctable-class.md):  
  
    ```  
    CDataSource ds;  
    CSession ss;  
    class CMyTableName : public CCommand<CAccessor<CMyTableNameAccessor> >  
    ```  
  
-   Call **CoInitialize** to initialize COM. This is usually called in the main code. For example:  
  
    ```  
    HRESULT hr = CoInitialize(NULL);  
    ```  
  
-   Call [CDataSource::Open](../VS_csharp/cdatasource--open.md) or one of its variations.  
  
-   Open a connection to the data source, open the session, and open and initialize the rowset (and if a command, also execute it):  
  
    ```  
    hr = ds.Open();  
    hr = ss.Open(ds);  
    hr = rs.Open();            // (Open also executes the command)  
    ```  
  
-   Optionally, set rowset properties using `CDBPropSet::AddProperty` and pass them as a parameter to `rs.Open`. For an example of how this is done, see GetRowsetProperties in [Consumer Wizard-Generated Methods](../VS_csharp/consumer-wizard-generated-methods.md).  
  
-   You can now use the rowset to retrieve/manipulate the data.  
  
-   When your application is done, close the connection, session, and rowset:  
  
    ```  
    rs.Close();  
    ss.Close();  
    ds.Close();  
    ```  
  
     If you are using a command, you might want to call `ReleaseCommand` after **Close**. The code example in [CCommand::Close](../VS_csharp/ccommand--close.md) shows how to call **Close** and `ReleaseCommand`.  
  
-   Call **CoUnInitialize** to uninitialize COM. This is usually called in the main code.  
  
    ```  
    CoUninitialize();  
    ```  
  
## See Also  
 [Creating an OLE DB Consumer](../VS_csharp/creating-an-ole-db-consumer.md)