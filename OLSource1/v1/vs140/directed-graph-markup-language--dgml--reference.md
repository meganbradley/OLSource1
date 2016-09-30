---
title: "Directed Graph Markup Language (DGML) reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: cc3e4ae7-60fa-4e22-9227-98020b480b73
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Directed Graph Markup Language (DGML) reference
Directed Graph Markup Language (DGML) describes information used for visualization and to perform complexity analysis, and is the format used to persist code maps in Visual Studio. It uses simple XML to describe both cyclical and acyclic directed graphs. A directed graph is a set of nodes that are connected by links, or edges. Nodes and links can be used represent network structures, such as elements in a software project.  
  
 Note that some versions of Visual Studio support only a subset of DGML capabilities, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
> [!NOTE]
>  When you edit a .dgml file, IntelliSense helps you identify attributes that are available for each element and their values. To specify color in an attribute, use names for common colors, such as "Blue", or ARGB hexadecimal values, such as "#ffa0b1c3". DGML uses a small subset of Windows Presentation Foundation (WPF) color definition formats. For more information, see [Colors Class](http://go.microsoft.com/fwlink/?LinkId=182345).  
  
##  \<a name="DGML">\</a> DGML syntax  
 The following table describes kinds of elements that are used in DGML:  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     This element is the root element of code map (.dgml) document. All other DGML elements appear within the scope of this element.  
  
     The following list describes optional attributes that you can include:  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> - The color of the map background  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> - The location of an image file to use as the map background.  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> - When the map is set to tree layout (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), arrange the nodes so that most of the links flow in the specified direction: <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. See [Change the map layout](../vs140/browse-and-rearrange-code-maps.md#Selecting).  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> - Set the map to the following layouts: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (tree layout), <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (quick clusters), or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. See [Change the map layout](../vs140/browse-and-rearrange-code-maps.md#Selecting).  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> - When the map is set to tree layout or quick clusters layout, show only those nodes that are a specified number (1-7) of links away from selected nodes. See [Change the map layout](../vs140/browse-and-rearrange-code-maps.md#Selecting).  
  
     Example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
     This optional element contains a list of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> elements, which define nodes on the map. For more information, see the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element.  
  
    > [!NOTE]
    >  When you reference an undefined node in a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> element, the map creates a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element automatically.  
  
     Example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
     This element defines a single node. It appears within the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> element list.  
  
     This element must include the following attributes:  
  
     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> - The unique name of the node and the default value of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> attribute, if no separate <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attribute is specified. This name must match the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> attribute of the link that references it.  
  
     The following list describes some of the optional attributes that you can include:  
  
     <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> - The display name of the node.  
  
     Style attributes. See [Apply custom styles to code elements and links](../vs140/customize-code-maps-by-editing-the-dgml-files.md).  
  
     <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> - The name of a category that identifies elements that share this attribute. For more information, see the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element.  
  
     <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> - The name of a property that identifies elements that have the same property value. For more information, see the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> element.  
  
     <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> - If the node contains other nodes, set this attribute to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to show or hide its contents. There must be a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> element that includes the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> attribute and specifies the parent node as the source node and the child node as the target node. See [Group code elements](../vs140/customize-code-maps-by-editing-the-dgml-files.md#OrganizeNodes).  
  
     <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> - Set this attribute to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Uses <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. See [Hide or show nodes and links](../vs140/browse-and-rearrange-code-maps.md#HidingShowing).  
  
     <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> - Set this attribute to link to a document or URL. See [Link documents or URLs to code elements or to links](../vs140/customize-code-maps-by-editing-the-dgml-files.md#AddReferences).  
  
     Example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
     This element contains the list of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> elements, which define links between nodes. For more information, see the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> element.  
  
     Example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
     This element defines a single link that connects a source node to a target node. It appears within the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> element list.  
  
    > [!NOTE]
    >  If this element references an undefined node, the map document automatically creates a node that has the specified attributes, if any.  
  
     This element must include the following attributes:  
  
     <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> - The source node of the link  
  
     <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> - The target node of the link  
  
     The following list describes some of the optional attributes that you can include:  
  
     <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> - The display name of the link  
  
     Style attributes. See [Apply custom styles to code elements and links](../vs140/customize-code-maps-by-editing-the-dgml-files.md).  
  
     <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> - The name of a category that identifies elements that share this attribute. For more information, see the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> element.  
  
     <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> - The name of a property that identifies elements that have the same property value. For more information, see the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element.  
  
     Example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
     This element contains the list of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> elements. For more information, see the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> element.  
  
     Example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
     This element defines a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> attribute, which is used to identify elements that share this attribute. A <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> attribute can be used to organize map elements, provide for shared attributes through inheritance, or define additional metadata.  
  
     This element must include the following attributes:  
  
     <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> - The unique name of the category and the default value of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> attribute, if no separate <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> attribute is specified.  
  
     The following list describes some of the optional attributes that you can include:  
  
     <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> - A reader-friendly name for the category.  
  
     <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> - The parent category from which the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> of the current element inherits.  
  
     In the example for this element, the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> category inherits its <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> attribute from the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> category. See "To create hierarchical categories" in [Assign categories to code elements and links](../vs140/customize-code-maps-by-editing-the-dgml-files.md).  
  
     Categories also provide some basic template behavior that controls the appearance of nodes and links when they are displayed on a map. See [Apply custom styles to code elements and links](../vs140/customize-code-maps-by-editing-the-dgml-files.md).  
  
     Example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
     This element contains the list of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> elements. For more information, see the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element.  
  
     Example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
     This element defines a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> attribute that you can use to assign a value to any DGML element or attribute, including categories and other properties.  
  
     This element must include the following attributes:  
  
    -   <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> - The unique name of the property and the default value of the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> attribute, if no separate <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> attribute is specified.  
  
    -   <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> - The type of data stored by the property  
  
     If you want the property to appear in the **Properties** window, use the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> property to specify the property's display name.  
  
     See [Assign categories to code elements and links](../vs140/customize-code-maps-by-editing-the-dgml-files.md#AssignCategories).  
  
     Example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
###  \<a name="AddAlias">\</a> Aliases for commonly-used paths  
 Replacing commonly-used paths with aliases helps reduce the size of the .dgml file and the time required to load or save the file. To create an alias, add a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> section at the end of the .dgml file. In this section, add a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element to define an alias for the path:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To reference the alias from an element in the .dgml file, enclose the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> of the \<Path/> element with a dollar sign ($) and parentheses (()):  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [Map dependencies across your solutions](../vs140/map-dependencies-across-your-solutions.md)   
 [Use code maps to debug your applications](../vs140/use-code-maps-to-debug-your-applications.md)   
 [Find potential problems using code map analyzers](../vs140/find-potential-problems-using-code-map-analyzers.md)