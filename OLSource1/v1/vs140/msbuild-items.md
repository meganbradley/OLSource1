---
title: "MSBuild Items"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSBuild, Items"
ms.assetid: d762eff4-c92a-4b5f-a944-1ca30aa22319
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Items
MSBuild items are inputs into the build system, and they typically represent files. Items are grouped into item types based on their element names. Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process.  
  
 Because items are named by the item type to which they belong, the terms "item" and "item value" can be used interchangeably.  
  
 **In this topic**  
  
-   [Creating Items in a Project File](#BKMK_Creating1)  
  
-   [Creating Items During Execution](#BKMK_Creating2)  
  
-   [Referencing Items in a Project File](#BKMK_ReferencingItems)  
  
-   [Using Wildcards to Specify Items](#BKMK_Wildcards)  
  
-   [Using the Exclude Attribute](#BKMK_ExcludeAttribute)  
  
-   [Item Metadata](#BKMK_ItemMetadata)  
  
    -   [Referencing Item Metadata in a Project File](#BKMK_ReferencingItemMetadata)  
  
    -   [Well-known Item Metadata](#BKMK_WellKnownItemMetadata)  
  
    -   [Transforming Item Types Using Metadata](#BKMK_Transforming)  
  
-   [Item Definitions](#BKMK_ItemDefinitions)  
  
-   [Attributes for Items in an ItemGroup of a Target](#BKMK_AttributesWithinTargets)  
  
    -   [Remove Attribute](#BKMK_RemoveAttribute)  
  
    -   [KeepMetadata Attribute](#BKMK_KeepMetadata)  
  
    -   [RemoveMetadata Attribute](#BKMK_RemoveMetadata)  
  
    -   [KeepDuplicates Attribute](#BKMK_KeepDuplicates)  
  
##  \<a name="BKMK_Creating1">\</a> Creating Items in a Project File  
 You declare items in the project file as child elements of an [ItemGroup](../vs140/itemgroup-element--msbuild-.md) element. The name of the child element is the type of the item. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute of the element specifies the items (files) to be included with that item type. For example, the following XML creates an item type that’s named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, which includes two files.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The item "file2.cs" doesn’t replace the item "file1.cs"; instead, the file name is appended to the list of values for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> item type. You can’t remove an item from an item type during the evaluation phase of a build.  
  
 The following XML creates the same item type by declaring both files in one <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute. Notice that the file names are separated by a semicolon.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="BKMK_Creating2">\</a> Creating Items During Execution  
 Items that are outside [Target](../vs140/target-element--msbuild-.md) elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, items can be created or modified in the following ways:  
  
-   Any task can emit an item. To emit an item, the [Task](../vs140/task-element--msbuild-.md) element must have a child [Output](../vs140/output-element--msbuild-.md) element that has an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute.  
  
-   The [CreateItem](../vs140/createitem-task.md) task can emit an item. This usage is deprecated.  
  
-   Starting in the .NET Framework 3.5, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements may contain [ItemGroup](../vs140/itemgroup-element--msbuild-.md) elements that may contain item elements.  
  
##  \<a name="BKMK_ReferencingItems">\</a> Referencing Items in a Project File  
 To reference item types throughout the project file, you use the syntax @(<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>). For example, you would reference the item type in the previous example by using <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. By using this syntax, you can pass items to tasks by specifying the item type as a parameter of that task. For more information, see [How To: Build All Files in a Directory](../vs140/how-to--select-the-files-to-build.md).  
  
 By default, the items of an item type are separated by semicolons (;) when it’s expanded. You can use the syntax @(*ItemType*, '*separator*') to specify a separator other than the default. For more information, see [How To: Display an Item List Separated with Commas](../vs140/how-to--display-an-item-list-separated-with-commas.md).  
  
##  \<a name="BKMK_Wildcards">\</a> Using Wildcards to Specify Items  
 You can use the **, \*, and ? wildcard characters to specify a group of files as inputs for a build instead of listing each file separately.  
  
-   The ? wildcard character matches a single character.  
  
-   The * wildcard character matches zero or more characters.  
  
-   The ** wildcard character sequence matches a partial path.  
  
 For example, you can specify all the .cs files in the directory that contains the project file by using the following element in your project file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following element selects all .vb files on the D: drive:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information about wildcard characters, see [How To: Build All Files in a Directory](../vs140/how-to--select-the-files-to-build.md).  
  
##  \<a name="BKMK_ExcludeAttribute">\</a> Using the Exclude Attribute  
 Item elements can contain the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute, which excludes specific items (files) from the item type. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute is typically used together with wildcard characters. For example, the following XML adds every .cs file in the directory to the CSFile item type, except the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute affects only the items that are added by the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute in the item element that contains them both. The following example wouldn’t exclude the file Form1.cs, which was added in the preceding item element.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For more information, see [How To: Build all Files in a Directory Except One](../vs140/how-to--exclude-files-from-the-build.md).  
  
##  \<a name="BKMK_ItemMetadata">\</a> Item Metadata  
 Items may contain metadata in addition to the information in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attributes. This metadata can be used by tasks that require more information about the items or to batch tasks and targets. For more information, see [MSBuild Batching](../vs140/msbuild-batching.md).  
  
 Metadata is a collection of key-value pairs that are declared in the project file as child elements of an item element. The name of the child element is the name of the metadata, and the value of the child element is the value of the metadata.  
  
 The metadata is associated with the item element that contains it. For example, the following XML adds <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> metadata that has the value <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to both the "one.cs" and the "two.cs" items of the CSFile item type.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An item can have zero or more metadata values. You can change metadata values at any time. If you set metadata to an empty value, you effectively remove it from the build.  
  
###  \<a name="BKMK_ReferencingItemMetadata">\</a> Referencing Item Metadata in a Project File  
 You can reference item metadata throughout the project file by using the syntax %(<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>). If ambiguity exists, you can qualify a reference by using the name of the item type. For example, you can specify %(*ItemType.ItemMetaDataName*).The following example uses the Display metadata to batch the Message task. For more information about how to use item metadata for batching, see [How To: Batch Targets and Tasks with Item Metadata](../vs140/item-metadata-in-task-batching.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
###  \<a name="BKMK_WellKnownItemMetadata">\</a> Well-known Item Metadata  
 When an item is added to an item type, that item is assigned some well-known metadata. For example, all items have the well-known metadata <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, whose value is the file name of the item. For more information, see [MSBuild Well-known Item Metadata](../vs140/msbuild-well-known-item-metadata.md).  
  
###  \<a name="BKMK_Transforming">\</a> Transforming Item Types By Using Metadata  
 You can transform item lists into new item lists by using metadata. For example, you can transform an item type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> that has items that represent .cpp files into a corresponding list of .obj files by using the expression <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 The following code creates a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> item type that contains copies of all <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> items with <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> metadata. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> metadata value becomes the value of the new metadata <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 For more information, see [MSBuild Transforms](../vs140/msbuild-transforms.md).  
  
##  \<a name="BKMK_ItemDefinitions">\</a> Item Definitions  
 Starting in the .NET Framework 3.5, you can add default metadata to any item type by using the [ItemDefinitionGroup element](../vs140/itemdefinitiongroup-element--msbuild-.md). Like well-known metadata, the default metadata is associated with all items of the item type that you specify. You can explicitly override default metadata in an item definition. For example, the following XML gives the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> items "one.cs" and "three.cs" the metadata <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> with the value "Monday". The code gives the item "two.cs" the metadata <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> with the value "Tuesday".  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 For more information, see [Item Definitions](../vs140/item-definitions.md).  
  
##  \<a name="BKMK_AttributesWithinTargets">\</a> Attributes for Items in an ItemGroup of a Target  
 Starting in the .NET Framework 3.5, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> elements may contain [ItemGroup](../vs140/itemgroup-element--msbuild-.md) elements that may contain item elements. The attributes in this section are valid when they are specified for an item in an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that's in a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
###  \<a name="BKMK_RemoveAttribute">\</a> Remove Attribute  
 Items in an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> of a target may contain the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> attribute, which removes specific items (files) from the item type. This attribute was introduced in the .NET Framework 3.5.  
  
 The following example removes every .config file from the Compile item type.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
###  \<a name="BKMK_KeepMetadata">\</a> KeepMetadata Attribute  
 If an item is generated within a target, the item element can contain the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute. If this attribute is specified, only the metadata that is specified in the semicolon-delimited list of names will be transferred from the source item to the target item. An empty value for this attribute is equivalent to not specifying it. The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
###  \<a name="BKMK_RemoveMetadata">\</a> RemoveMetadata Attribute  
 If an item is generated within a target, the item element can contain the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> attribute. If this attribute is specified, all metadata is transferred from the source item to the target item except metadata whose names are contained in the semicolon-delimited list of names. An empty value for this attribute is equivalent to not specifying it. The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
###  \<a name="BKMK_KeepDuplicates">\</a> KeepDuplicates Attribute  
 If an item is generated within a target, the item element can contain the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> attribute. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> attribute that specifies whether an item should be added to the target group if the item is an exact duplicate of an existing item.  
  
 If the source and target item have the same Include value but different metadata, the item is added even if <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. An empty value for this attribute is equivalent to not specifying it. The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> attribute was introduced in the .NET Framework 4.5.  
  
 The following example illustrates how to use the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild](../vs140/msbuild.md)   
 [How To: Select the Files to Build](../vs140/how-to--select-the-files-to-build.md)   
 [How To: Exclude Files from the Build](../vs140/how-to--exclude-files-from-the-build.md)   
 [How To: Display an Item List Separated with Commas](../vs140/how-to--display-an-item-list-separated-with-commas.md)   
 [Item Definitions](../vs140/item-definitions.md)   
 [MSBuild Batching](../vs140/msbuild-batching.md)   
 [Item Element (MSBuild)](../vs140/item-element--msbuild-.md)