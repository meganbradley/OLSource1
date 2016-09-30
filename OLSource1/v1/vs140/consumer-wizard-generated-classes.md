---
title: "Consumer Wizard-Generated Classes"
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
  - "attribute-injected classes and methods"
  - "wizard-generated classes and methods"
  - "OLE DB consumers, wizard-generated classes and methods"
  - "command classes in OLE DB consumer"
  - "classes [C++], OLE DB Consumer Wizard-generated"
  - "consumer wizard-generated classes and methods"
  - "user record classes in OLE DB consumer"
ms.assetid: dba0538f-2afe-4354-8cbb-f202ea8ade5a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Consumer Wizard-Generated Classes
When you use the ATL OLE DB Consumer Wizard to generate a consumer, you have the choice of using OLE DB Templates or OLE DB attributes. In both cases, the wizard generates a command class and a user record class. The command class contains code to open the data source and rowset you specified in the wizard. The user record class contains a column map for the database table you selected. However, the generated code differs in each case:  
  
-   If you select a templated consumer, the wizard generates a command class and a user record class. The command class will have the name that you enter in the Class box in the wizard (for example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), and the user record class will have a name of the form "*ClassName*Accessor" (for example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). Both classes are placed in the consumer's header file.  
  
-   If you select an attributed consumer, the user record class will have a name of the form "_*ClassName*Accessor" and will be injected. That is, you will be able to view only the command class in the text editor; you can only view the user record class as injected code. For information about viewing injected code, see [Debugging Injected Code](../vs140/how-to--debug-injected-code.md).  
  
 The following examples use a command class created on the Products table of the Northwind database to demonstrate the wizard-generated consumer code for the command class and user record class.  
  
## Templated User Record Classes  
 If you create an OLE DB consumer using the OLE DB Templates (rather than the OLE DB attributes), the wizard generates code as described in this section.  
  
### Column Data Members  
 The first part of the user record class includes the data member declarations and the status and length data members for each data-bound column. For information about these data members, see [Field Status Data Members in Wizard-Generated Accessors](../vs140/field-status-data-members-in-wizard-generated-accessors.md).  
  
> [!NOTE]
>  If you modify the user record class or write your own consumer, the data variables must come before the status and length variables.  
  
> [!NOTE]
>  The ATL OLE DB Consumer Wizard uses the **DB_NUMERIC** type to bind numeric data types. It formerly used **DBTYPE_VARNUMERIC** (the format of which is described by the **DB_VARNUMERIC** type; see Oledb.h). If you do not use the wizard to create consumers, it is recommended that you use **DB_NUMERIC**.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Rowset Properties  
 Next, the wizard sets rowset properties. If you selected **Change**, **Insert**, or **Delete** in the ATL OLE DB Consumer Wizard, the appropriate properties are set here (DBPROP_IRowsetChange is always set, then one or more of DBPROPVAL_UP_CHANGE, DBPROPVAL_UP_INSERT, and/or DBPROPVAL_UP_DELETE, respectively).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Command or Table Class  
 If you specify a command class, the wizard declares the command class; for templated code, the command looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Column Map  
 The wizard then generates the column bindings or column map. To fix several issues with some providers, the following code might bind columns in a different order than that reported by the provider.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Class Declaration  
 Finally, the wizard generates a command class declaration such as the following:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Attribute-Injected User Record Classes  
 If you create an OLE DB consumer using the database attributes ([db_command](../vs140/db_command.md) or [db_table](../vs140/db_table.md)), the attributes inject a user record class with a name of the form "_*ClassName*Accessor." For example, if you named your command class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the user record class will be <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Although the user record class appears in Class View, double-clicking it navigates to the command or table class in the header file instead. In these cases, you can only view the actual declaration of the user record class by viewing the attribute-injected code.  
  
 There can be potential complications if you add or override methods in attributed consumers. For example, you could add a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> constructor to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> declaration, but note that in reality this adds a constructor to the injected <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class. Such a constructor can initialize the columns/parameters, but you cannot create a copy constructor this way, because it cannot directly instantiate the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. If you need a constructor (or other method) directly on the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class, it is recommended that you define a new class deriving from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and add the necessary methods there.  
  
 In the following example, the wizard generates a declaration for the class <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, but the user record class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not appear, because the attributes inject it.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The injected command class declaration looks like this:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Most of the injected code is the same as or similar to the templated version. The main differences are in the injected methods, which are described in [Consumer Wizard-Generated Methods](../vs140/consumer-wizard-generated-methods.md).  
  
 For information about viewing injected code, see [Debugging Injected Code](../vs140/how-to--debug-injected-code.md).  
  
## See Also  
 [Creating an OLE DB Consumer Using a Wizard](../vs140/creating-an-ole-db-consumer-using-a-wizard.md)