---
title: "Creating an Updatable Provider"
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
  - "OLE DB providers, updatable"
  - "notifications, support in providers"
  - "OLE DB providers, creating"
ms.assetid: bdfd5c9f-1c6f-4098-822c-dd650e70ab82
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating an Updatable Provider
Visual C++ 6.0 supported only read-only providers. Visual C++ .NET supports updatable providers or providers that can update (write to) the data store. This topic discusses how to create updatable providers using OLE DB templates.  
  
 This topic assumes that you are starting with a workable provider. There are two steps to creating an updatable provider. You must first decide how the provider will make changes to the data store; specifically, whether changes are to be done immediately or deferred until an update command is issued. The section "[Making Providers Updatable](#vchowmakingprovidersupdatable)" describes the changes and settings you need to do in the provider code.  
  
 Next, you must make sure your provider contains all the functionality to support anything the consumer might request of it. If the consumer wants to update the data store, the provider has to contain code that persists data to the data store. For example, you might use the C Run-Time Library or MFC to perform such operations on your data source. The section "[Writing to the Data Source](#vchowwritingtothedatasource)" describes how to write to the data source, deal with **NULL** and default values, and set column flags.  
  
> [!NOTE]
>  UpdatePV is an example of an updatable provider. UpdatePV is the same as MyProv but with updatable support.  
  
##  \<a name="vchowmakingprovidersupdatable">\</a> Making Providers Updatable  
 The key to making a provider updatable is understanding what operations you want your provider to perform on the data store and how you want the provider to carry out those operations. Specifically, the major issue is whether updates to the data store are to be done immediately or deferred (batched) until an update command is issued.  
  
 You must first decide whether to inherit from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in your rowset class. Depending on which of these you choose to implement, the functionality of three methods will be affected: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, **InsertRows**, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
-   If you inherit from [IRowsetChangeImpl](../vs140/irowsetchangeimpl-class.md), calling these three methods immediately changes the data store.  
  
-   If you inherit from [IRowsetUpdateImpl](../vs140/irowsetupdateimpl-class.md), the methods defer changes to the data store until you call **Update**, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or **Undo**. If the update involves several changes, they are performed in batch mode (note that batching changes can add considerable memory overhead).  
  
 Note that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> gives you change capability plus batch capability.  
  
#### To support updatability in your provider  
  
1.  In your rowset class, inherit from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. These classes provide appropriate interfaces for changing the data store:  
  
     **Adding IRowsetChange**  
  
     Add <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to your inheritance chain using this form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Also add <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> section in your rowset class.  
  
     **Adding IRowsetUpdate**  
  
     Add <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to your inheritance chain using this form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  You should remove the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> line from your inheritance chain. This one exception to the directive previously mentioned must include the code for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
2.  Add the following to your COM map (**BEGIN_COM_MAP ... END_COM_MAP**):  
  
    |If you implement|Add to COM map|  
    |----------------------|--------------------|  
    |<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
3.  In your command, add the following to your property set map (**BEGIN_PROPSET_MAP ... END_PROPSET_MAP**):  
  
    |If you implement|Add to property set map|  
    |----------------------|-----------------------------|  
    |<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
    |<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
4.  In your property set map, you should also include all of the following settings as they appear below:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     You can find the values used in these macro calls by looking in Atldb.h for the property IDs and values (if Atldb.h differs from the online documentation, Atldb.h supersedes the documentation).  
  
    > [!NOTE]
    >  Many of the **VARIANT_FALSE** and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> settings are required by the OLE DB templates; the OLE DB specification says they can be read/write, but the OLE DB templates can only support one value.  
  
     **If you implement IRowsetChangeImpl**  
  
     If you implement <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, you must set the following properties on your provider. These properties are primarily used to request interfaces through **ICommandProperties::SetProperties**.  
  
    -   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>: Setting this automatically sets **DBPROP_IRowsetChange**.  
  
    -   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>: A bitmask specifying the supported methods on <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>: <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
    -   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>: Consumer can call **IRowsetChange::DeleteRows** or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for newly inserted rows.  
  
    -   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>: Rowset will not reorder inserted or updated rows.  
  
     **If you implement IRowsetUpdateImpl**  
  
     If you implement <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, you must set the following properties on your provider, in addition to setting all the properties for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> previously listed:  
  
    -   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
    -   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>: Must be READ_ONLY AND VARIANT_TRUE.  
  
    -   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>: Must be READ_ONLY AND VARIANT_TRUE.  
  
    -   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>: Must be READ_ONLY AND VARIANT_TRUE.  
  
    -   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>: Must be READ_ONLY AND VARIANT_TRUE.  
  
    -   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>: Must be READ_ONLY AND VARIANT_TRUE.  
  
    -   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
        > [!NOTE]
        >  If you support notifications, you might also have some other properties as well; see the section on <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for this list.  
  
     For example of how the properties are set, see the property set map in **CUpdateCommand** (in Rowset.h) in [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f).  
  
##  \<a name="vchowwritingtothedatasource">\</a> Writing to the Data Source  
 To read from the data source, call the **Execute** function. To write to the data source, call the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> function. (In a general sense, flush means to save modifications you make to a table or index to disk.)  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The row handle (*HROW*) and accessor handle (*HACCESSOR*) arguments allow you to specify the region to write. Typically, you write a single data field at a time.  
  
 The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method writes data in the format in which it was originally stored. If you do not override this function, your provider will function correctly but changes will not be flushed to the data store.  
  
### When to Flush  
 The provider templates call <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> whenever data needs to be written to the data store; this usually (but not always) occurs as a result of calls to the following functions:  
  
-   **IRowsetChange::DeleteRows**  
  
-   **IRowsetChange::SetData**  
  
-   **IRowsetChange::InsertRows** (if there is new data to insert in the row)  
  
-   **IRowsetUpdate::Update**  
  
### How It Works  
 The consumer makes a call that requires a flush (such as **Update**) and this call is passed to the provider, which always does the following:  
  
-   Calls <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> whenever you have a status value bound (see *OLE DB Programmers Reference*, Chapter 6, *Data Parts: Status*).  
  
-   Checks column flags.  
  
-   Calls <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 These three steps help provide security. Then the provider calls <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### How to Implement FlushData  
 To implement <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, you need to take into account several issues:  
  
-   Making sure that the data store can handle changes.  
  
-   Handling **NULL** values.  
  
-   Handling default values.  
  
 To implement your own <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method, you need to:  
  
-   Go to your rowset class.  
  
-   In the rowset class put the declaration of:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Provide an implementation of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 A good implementation of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> stores only the rows and columns that are actually updated. You can use the *HROW* and *HACCESSOR* parameters to determine the current row and column being stored for optimization.  
  
 Typically, the biggest challenge is working with your own native data store. If possible, try to:  
  
-   Keep the method of writing to your data store as simple as possible.  
  
-   Handle **NULL** values (optional but advised).  
  
-   Handle default values (optional but advised).  
  
 The best thing to do is to have actual specified values in your data store for **NULL** and default values. It is best if you can extrapolate this data. If not, you are advised not to allow **NULL** and default values.  
  
 The following example shows how <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is implemented in the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class in the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample (see Rowset.h in the sample code):  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Handling Changes  
 For your provider to handle changes, you first need to make sure your data store (such as a text file or video file) has facilities that enable you to make changes on it. If it does not, you should create that code separately from the provider project.  
  
### Handling NULL Data  
 It is possible that an end user will send **NULL** data. When you write **NULL** values to fields in the data source, there can be potential problems. Imagine an order-taking application that accepts values for city and postal code; it could accept either or both values, but not neither, because in that case delivery would be impossible. You therefore have to restrict certain combinations of **NULL** values in fields that make sense for your application.  
  
 As the provider developer, you have to consider how you will store that data, how you will read that data from the data store, and how you specify that to the user. Specifically, you must consider how to change the data status of rowset data in the data source (for example, DataStatus = **NULL**). You decide what value to return when a consumer accesses a field containing a **NULL** value.  
  
 Look at the code in the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample; it illustrates how a provider can handle **NULL** data. In UpdatePV, the provider stores **NULL** data by writing the string "NULL" in the data store. When it reads **NULL** data from the data store, it sees that string and then empties the buffer, creating a **NULL** string. It also has an override of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> in which it returns **DBSTATUS_S_ISNULL** if that data value is empty.  
  
### Marking Nullable Columns  
 If you also implement schema rowsets (see <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>), your implementation should specify in the **DBSCHEMA_COLUMNS** rowset (usually marked in your provider by **C***xxx***SchemaColSchemaRowset**) that the column is nullable.  
  
 You also need to specify that all nullable columns contain the **DBCOLUMNFLAGS_ISNULLABLE** value in your version of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 In the OLE DB templates implementation, if you fail to mark columns as nullable, the provider assumes that they must contain a value and will not allow the consumer to send it null values.  
  
 The following example shows how the **CommonGetColInfo** function is implemented in **CUpdateCommand** (see UpProvRS.cpp) in UpdatePV. Note how the columns have this **DBCOLUMNFLAGS_ISNULLABLE** for nullable columns.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Default Values  
 As with **NULL** data, you have the responsibility to deal with changing default values.  
  
 The default of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and **Execute** is to return <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. Therefore, if you do not override this function, the changes appear to succeed (<CodeContentPlaceHolder>71\</CodeContentPlaceHolder> will be returned), but they will not be transmitted to the data store.  
  
 In the [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) sample (in Rowset.h), the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> method handles default values as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Column Flags  
 If you support default values on your columns, you need to set it using metadata in the **\<***provider class***>SchemaRowset** class. Set *m_bColumnHasDefault* = <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 You also have the responsibility to set the column flags, which are specified using the **DBCOLUMNFLAGS** enumerated type. The column flags describe column characteristics.  
  
 For example, in the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class in [UpdatePV](assetId:///c8bed873-223c-4a7d-af55-f90138c6f38f) (in Session.h), the first column is set up this way:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This code specifies, among other things, that the column supports a default value of 0, that it be writeable, and that all data in the column have the same length. If you want the data in a column to have variable length, you would not set this flag.  
  
## See Also  
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)