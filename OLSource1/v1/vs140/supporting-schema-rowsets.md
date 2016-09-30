---
title: "Supporting Schema Rowsets"
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
  - "schema rowsets"
  - "OLE DB consumer templates, schema rowsets"
  - "OLE DB providers, schema rowsets"
  - "OLE DB, schema rowsets"
ms.assetid: 71c5e14b-6e33-4502-a2d9-a1dc6d6e9ba0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Supporting Schema Rowsets
Schema rowsets allow consumers to obtain information about a data store without knowing its underlying structure, or schema. For example, a data store might have tables organized into a user-defined hierarchy, so there would be no way to ensure knowledge of the schema except by reading it. (As another example, note that the Visual C++ wizards use schema rowsets to generate accessors for the consumer.) To allow the consumer to do this, the provider's session object exposes methods on the [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) interface. In Visual C++ applications, you use the [IDBSchemaRowsetImpl](../vs140/idbschemarowsetimpl-class.md) class to implement **IDBSchemaRowset**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> supports the following methods:  
  
-   [CheckRestrictions](../vs140/idbschemarowsetimpl--checkrestrictions.md) checks the validity of restrictions against a schema rowset.  
  
-   [CreateSchemaRowset](../vs140/idbschemarowsetimpl--createschemarowset.md) implements a COM object creator function for the object specified by the template parameter.  
  
-   [SetRestrictions](../vs140/idbschemarowsetimpl--setrestrictions.md) specifies which restrictions you support on a particular schema rowset.  
  
-   [IDBSchemaRowset::GetRowset](../vs140/idbschemarowsetimpl--getrowset.md) returns a schema rowset (inherited from interface).  
  
-   [GetSchemas](../vs140/idbschemarowsetimpl--getschemas.md) returns a list of schema rowsets accessible by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (inherited from interface).  
  
## ATL OLE DB Provider Wizard Support  
 The ATL OLE DB Provider Wizard creates three schema classes in the session header file:  
  
-   **C** *ShortName* **SessionTRSchemaRowset**  
  
-   **C** *ShortName* **SessionColSchemaRowset**  
  
-   **C** *ShortName* **SessionPTSchemaRowset**  
  
 These classes respond to consumer requests for schema information; note that the OLE DB specification requires that these three schema rowsets be supported:  
  
-   **C** *ShortName* **SessionTRSchemaRowset** handles requests for table information (the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> schema rowset).  
  
-   **C** *ShortName* **SessionColSchemaRowset** handles requests for column information (the **DBSCHEMA_COLUMNS** schema rowset). The wizard supplies sample implementations for these classes, which return schema information for a DOS provider.  
  
-   **C** *ShortName* **SessionPTSchemaRowset** handles requests for schema information about the provider type (the **DBSCHEMA_PROVIDER_TYPES** schema rowset). The default implementation provided by the wizard returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 You can customize these classes to handle schema information appropriate to your provider:  
  
-   In **C***ShortName***SessionTRSchemaRowset**, you must fill out the catalog, table, and description fields (**trData.m_szType**, **trData.m_szTable**, and **trData.m_szDesc**). The wizard-generated example uses only one row (table). Other providers might return more than one table.  
  
-   In **C***ShortName***SessionColSchemaRowset**, you pass the name of the table as a **DBID**.  
  
## Setting Restrictions  
 An important concept in schema rowset support is setting restrictions, which you do using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Restrictions allow consumers to fetch only matching rows (for example, find all the columns in the table "MyTable"). Restrictions are optional, and in the case in which none are supported (the default), all data is always returned. For an example of a provider that does support restrictions, see the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample.  
  
## Setting up the Schema Map  
 Set up a schema map such as this one in Session.h in UpdatePV:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To support **IDBSchemaRowset**, you must support <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, **DBSCHEMA_COLUMNS**, and **DBSCHEMA_PROVIDER_TYPES**. You can add additional schema rowsets at your discretion.  
  
 Declare a schema rowset class with an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in UpdatePV:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, so it has all the restriction handling methods. Using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, declare three child classes (listed in the schema map above): <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Each of these child classes has an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method that handles its respective set of restrictions (search criteria). Each <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method compares the values of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameters. See the description of these parameters in [SetRestrictions](../vs140/idbschemarowsetimpl--setrestrictions.md).  
  
 For more information about which restrictions correspond to a particular schema rowset, consult the table of schema rowset GUIDs in [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
 For example, if you supported the **TABLE_NAME** restriction on <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, you would do the following:  
  
 First, look up <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and see that it supports four restrictions (in order).  
  
|Schema rowset restriction|Restriction value|  
|-------------------------------|-----------------------|  
|**TABLE_CATALOG**|0x1 (binary 1)|  
|**TABLE_SCHEMA**|0x2 (binary 10)|  
|**TABLE_NAME**|0x4 (binary 100)|  
|**TABLE_TYPE**|0x8 (binary 1000)|  
  
 Next, note that there is one bit for each restriction. Because you want to support **TABLE_NAME** only, you would return 0x4 in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element. If you supported **TABLE_CATALOG** and **TABLE_NAME**, you would return 0x5 (binary 101).  
  
 By default, the implementation returns 0 (does not support any restrictions) for any request. UpdatePV is an example of a provider that does support restrictions.  
  
### Example  
 This code is taken from the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample. UpdatePv supports the three required schema rowsets: <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, **DBSCHEMA_COLUMNS**, and **DBSCHEMA_PROVIDER_TYPES**. As an example of how to implement schema support in your provider, this topic takes you through implementing the **DBSCHEMA_TABLE** rowset.  
  
> [!NOTE]
>  The sample code might differ from what is listed here; you should regard the sample code as the more up-to-date version.  
  
 The first step in adding schema support is to determine which restrictions you are going to support. To determine which restrictions are available for your schema rowset, look at the OLE DB specification for the definition of **IDBSchemaRowset**. Following the main definition, you see a table containing the schema rowset name, the number of restrictions, and the restriction columns. Select the schema rowset you want to support and make a note of the number of restrictions and restriction columns. For example, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> supports four restrictions (**TABLE_CATALOG**, **TABLE_SCHEMA**, **TABLE_NAME**, and **TABLE_TYPE**):  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A bit represents each restriction column. If you want to support a restriction (that is, you can query by it), set that bit to a 1. If you do not want to support a restriction, set that bit to zero. From the line of code above, UpdatePV supports the **TABLE_NAME** and **TABLE_TYPE** restrictions on the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> rowset. These are the third (bit mask 100) and fourth (bit mask 1000) restrictions. Therefore, the bitmask for UpdatePv is 1100 (or 0x0C):  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function is similar to those in regular rowsets. You have three arguments: <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> variable is an output parameter that the provider can return the count of rows in the schema rowset. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter is an input parameter containing the number of restrictions passed by the consumer to the provider. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter is an array of **VARIANT** values that contain the restriction values.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> variable is based on the total number of restrictions for a schema rowset, regardless of whether the provider supports them. Because UpdatePv supports two restrictions (the third and fourth), this code only looks for a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value greater than or equal to three.  
  
 The value for the **TABLE_NAME** restriction is stored in <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> (again, the third restriction in a zero-based array is 2). You need to check that the restriction is not <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to actually support it. Note that **VT_NULL** is not equal to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. **VT_NULL** specifies a valid restriction value.  
  
 The UpdatePv definition of a table name is a fully qualified path name to a text file. Extract the restriction value and then attempt to open the file to ensure that the file does actually exist. If the file does not exist, return <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. This might seem a bit backwards but what the code is really telling the consumer is that there were no supported tables by the name specified. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> return means that the code executed correctly.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Supporting the fourth restriction (**TABLE_TYPE**) is similar to the third restriction. Check to see that the value is not <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. This restriction only returns the table type, **TABLE**. To determine the valid values for the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, look in Appendix B of the *OLE DB Programmer's Reference* in the **TABLES** rowset section.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This is where you actually create a row entry for the rowset. The variable <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> corresponds to **CTABLESRow**, a structure defined in the OLE DB provider templates. **CTABLESRow** corresponds to the **TABLES** rowset definition in Appendix B of the OLE DB specification. You only have one row to add because you can only support one table at a time.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 UpdatePV sets only three columns: **TABLE_NAME**, **TABLE_TYPE**, and **DESCRIPTION**. You should make a note of the columns for which you return information, because you need this information when you implement <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function is very important to the correct operation of the schema rowset. Because you do not return data for every column in the **TABLES** rowset, you need to specify which columns you return data for and which you do not.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Because your <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> function returns data for the **TABLE_NAME**, **TABLE_TYPE**, and **DESCRIPTION** fields from the **TABLES** rowset, you can look in Appendix B of the OLE DB specification and determine (by counting from the top down) that they are ordinals 3, 4, and 6. For each of those columns, return **DBSTATUS_S_OK**. For all the other columns, return **DBSTATUS_S_ISNULL**. It is important to return this status, because a consumer might not understand that the value you return is **NULL** or something else. Again, note that **NULL** is not equivalent to empty.  
  
 For more information about the OLE DB schema rowset interface, see the [IDBSchemaRowset](../vs140/idbschemarowsetimpl-class.md) interface in the OLE DB Programmer's Reference.  
  
 For information about how consumers can use **IDBSchemaRowset** methods, see [Obtaining Metadata with Schema Rowsets](../vs140/obtaining-metadata-with-schema-rowsets.md).  
  
 For an example of an provider that supports schema rowsets, see the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample.  
  
## See Also  
 [Advanced Provider Techniques](../vs140/advanced-provider-techniques.md)