---
title: "Customize code maps by editing the DGML files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "dependency graphs, creating path aliases"
  - "dependency graphs, linking items to nodes"
  - "graph documents, creating path aliases"
  - "dependency graphs, grouping nodes"
  - "graph documents, editing"
  - "graph documents, linking items to nodes"
  - "graph documents, customizing"
  - "graph documentings, assigning categories and properties"
  - "dependency graphs, editing"
  - "dependency graphs, customizing"
  - "graph documents, grouping nodes"
  - "dependency graphs, assigning categories and properties"
ms.assetid: a2e141f4-4fd8-4611-b236-6b9e7bc54fc1
caps.latest.revision: 97
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Customize code maps by editing the DGML files
To customize a code map, you can edit a map's Directed Graph Markup Language (.dgml) file. For example, you can edit elements to specify custom styles, assign properties and categories to code elements and links, or link documents or URLs to code elements or to links. For more information about DGML elements, see [Directed Graph Markup Language (DGML) reference](../vs140/directed-graph-markup-language--dgml--reference.md).  
  
 Edit the code map's .dgml file in a text or XML editor. If the map is part of your Visual Studio solution, select it in **Solution Explorer**, open the shortcut menu, and choose **Open With**, **XML (Text) Editor**.  
  
> [!NOTE]
>  To create code maps, you must have Visual Studio Enterprise. When you edit a code map in Visual Studio, it cleans up any unused DGML elements and attributes by deleting them when you save the .dgml file. It also creates code elements automatically when you manually add new links. When you save the .dgml file, any attributes that you added to an element might rearrange themselves in alphabetical order.  
  
##  \<a name="OrganizeNodes">\</a> Group code elements  
 You can add new groups or convert existing nodes into a group.  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  To convert a code element to a group, find the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> element for that code element.  
  
     \- or -  
  
     To add a new group, find the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> section. Add a new <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element.  
  
3.  In the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> element, add a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> attribute to specify whether the group appears expanded or collapsed. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  In the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> section, make sure that a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> element that has the following attributes exist for each relationship between a group code element and its child code elements:  
  
    -   A <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute that specifies the group code element  
  
    -   A <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute that specifies the child code element  
  
    -   A <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> attribute that specifies a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> relationship between the group code element and its child code element  
  
     For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     For more information about the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute, see [Assign categories to code elements and links](#AssignCategories).  
  
##  \<a name="ChangeGraphStyle">\</a> Change the style of the map  
 You can change the background color and border color of the map by editing the map's .dgml file. To change the style of code elements and links, see [Change the style of code elements and links](#Highlight).  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  In the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element, add any of the following attributes to change its style:  
  
     Background color  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Border color  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="Highlight">\</a> Change the style of code elements and links  
  
###  \<a name="CreateCustomStyles">\</a>   
 You can apply custom styles to the following code elements:  
  
-   Single code elements and links  
  
-   Groups of code elements and links  
  
-   Groups of code elements and links based on certain conditions  
  
> [!TIP]
>  If you have repeating styles across many code elements or links, you might consider applying a category to those code elements or links, and then applying a style to that category. For more information, see [Assign Categories to Code elements and Links](#AssignCategories) and [Assign Properties to Code elements and Links](#AssignProperties).  
  
##### To apply a custom style to a single code element  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the code element's <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element. Add any of these attributes to customize its style:  
  
     Background color  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Outline  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Outline thickness  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     Text color  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     Icon  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
     Text size  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     Text type  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     Text weight  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     Text style  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
     For example, you can specify <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> as the text style.  
  
     Texture  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
     Shape  
  
     To replace the shape with an icon, set the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and set the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> property to the path with the icon file.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     For example:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##### To apply a custom style to a single link  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> element that contains both the names of the source code element and target code element.  
  
3.  In the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> element, add any of the following attributes to customize its style:  
  
     Outline and arrowhead color  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
     Outline thickness  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
     Outline style  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
     For example:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##### To apply custom styles to a group of code elements or links  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  If a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> element does not exist, add one under the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> element after the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element.  
  
3.  In the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element, under the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> element and specify the following attributes:  
  
    -   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> *NameInLegendBox* <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> *NameInStylePickerBox* <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
     To apply a custom style to all target types, do not use a condition.  
  
##### To apply a conditional style to groups of code elements or links  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  In the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> element, add a <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> element that contains an <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> attribute to specify an expression that returns a Boolean value.  
  
     For example:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
     This expression uses the following Backus-Naur Form (BNF) syntax:  
  
     <Expression> ::= <BinaryExpression> &#124; <UnaryExpression> &#124; "("<Expression>")" &#124; <MemberBindings> &#124; <Literal> &#124; <Number>  
  
     <BinaryExpression> ::= <Expression> <Operator> <Expression>  
  
     <UnaryExpression> ::= "!" <Expression> &#124; "+" <Expression> &#124; "-" <Expression>  
  
     <Operator> ::= "<" &#124; "\<=" &#124; "=" &#124; ">=" &#124; ">" &#124; "!=" &#124; "or" &#124; "and" &#124; "+" &#124; "*" &#124; "/" &#124; "-"  
  
     <MemberBindings> ::= <MemberBindings> &#124; <MemberBinding> "." <MemberBinding>  
  
     <MemberBinding> ::= <MethodCall> &#124; <PropertyGet>  
  
     <MethodCall> ::= <Identifier> "(" <MethodArgs> ")"  
  
     <PropertyGet> ::= Identifier  
  
     <MethodArgs> ::= <Expression> &#124; <Expression> "," <MethodArgs> &#124; <empty>  
  
     <Identifier> ::= [^. ]*  
  
     <Literal> ::= single or double-quoted string literal  
  
     <Number> ::= string of digits with optional decimal point  
  
     You can specify multiple <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> elements, which must all be true to apply the style.  
  
3.  On the next line after the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> element, add one or multiple <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> elements to specify a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> attribute and a fixed <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> attribute or a computed <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> attribute to apply to the map, code elements, or links that meet the condition.  
  
     For example:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 As a simple complete example, the following condition specifies that a code element appears green or red based on whether its <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> category is set to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The following table includes some example conditions that you can use:  
  
 Set the font size as a function of the number of lines of code, which also changes the size of the code element. This example uses a single conditional expression to set multiple properties, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Set the background color of a code element based on the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> property. The styles are evaluated in the order that they appear, similar to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> statements.  
  
 In this example:  
  
1.  If <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is > 80, then set the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> property to green.  
  
2.  Else if <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is > 50, then set the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> property to a shade of orange based on the value of the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> property.  
  
3.  Else set the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> property to a shade of red based on the value of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> property.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Set the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> so that the icon replaces the shape. Use the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> property to specify the location of the icon.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
##  \<a name="AssignProperties">\</a> Assign properties to code elements and links  
 You can organize code elements and links by assigning properties to them. For example, you can select code elements that have specific properties so that you can group them, change their style, or hide them.  
  
#### To assign a property to a code element  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> element for that code element. Specify the name of the property and its value. For example:  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
3.  Add a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> section to specify attributes such as its visible name and data type:  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
#### To assign a property to a link  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> element that contains both the names of the source code element and target code element.  
  
3.  In the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> element, specify the name of the property and its value. For example:  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
4.  Add a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> section to specify attributes such as its visible name and data type:  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
##  \<a name="AssignCategories">\</a> Assign categories to code elements and links  
 The following sections demonstrate how you can organize code elements by assigning categories to them, and how you can create hierarchical categories that help you organize code elements and add attributes to child categories by using inheritance.  
  
#### To assign a category to a code element  
  
-   Open the .dgml file in a text or XML editor.  
  
-   Find the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> element for the code element that you want.  
  
-   In the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> element, add a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> attribute to specify the name of the category. For example:  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
     Add a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> section so that you can use the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> attribute to specify the display text for that category:  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
#### To assign a category to a link  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> element that contains both the names of the source code element and target code element.  
  
3.  In the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> element, add a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> attribute to specify the name of the category. For example:  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
4.  Add a <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> section so that you can use the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> attribute to specify the display text for that category:  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
#### To create hierarchical categories  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Add a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> element for the parent category, and then add the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> attribute to the child category's <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> element.  
  
     For example:  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
     In this example, the background of <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is green because its <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> attribute inherits the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> attribute of <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
##  \<a name="AddReferences">\</a> Link documents or URLs to code elements and links  
 You can link documents or URLs to code elements or to links by editing the map's .dgml file and adding a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> attribute to the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> element for a code element or the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> element for a link. You can then open and view that content from the code element or link. The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> attribute specifies the path of that content. This can be a path relative to the location of the .dgml file or an absolute path.  
  
> [!CAUTION]
>  If you use relative paths, and the .dgml file is moved to a different location, then those paths will no longer resolve. When you try to open and view the linked content, an error stating that the content cannot be viewed will occur.  
  
 For example, you might want to link the following code elements:  
  
-   To describe the changes to a class, you might link the URL of a work code element, document, or another .dgml file to the code element for a class.  
  
-   You might link a layer diagram to a group code element that represents a layer in the software's logical architecture.  
  
-   To show more information about a component that exposes an interface, you might link a component diagram to the code element for that interface.  
  
-   Link a code element to a Team Foundation Server work item or bug, or some other information that is related to the code element.  
  
#### To link a document or URL to a code element  
  
1.  Open the .dgml file in a text or XML editor.  
  
2.  Find the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> element for the code element that you want.  
  
3.  Perform one of the tasks in the following table:  
  
     A single code element  
  
    -   In the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> element, add a <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> attribute to specify the location of the code element.  
  
        > [!NOTE]
        >  You can have only one <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> attribute per element.  
  
     For example:  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
     Multiple code elements  
  
    1.  In the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> element, add a new attribute to specify the location of each reference.  
  
    2.  In the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> section:  
  
        1.  Add a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> element for each new type of reference.  
  
        2.  Set the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> attribute to the name of the new reference attribute.  
  
        3.  Add the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> attribute and set it to <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> to make the reference appear on the code element's **Go To Reference** shortcut menu.  
  
        4.  Use the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> attribute to specify the display text on the code element's **Go To Reference** shortcut menu.  
  
     For example:  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
     On the map, the name of the code element appears underlined. When you open the shortcut menu for the code element or the link, you will see a **Go To Reference** shortcut menu that contains the linked code elements for you to choose.  
  
4.  Use the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> attribute to specify a common string, such as a URL, that is used by multiple references instead of repeating that string in the reference.  
  
     The <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> attribute specifies a placeholder for the value of the reference. In the following example, the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> placeholder in the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> attribute will be replaced by the values of the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> attributes in the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> element to produce a full path:  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
5.  To view the referenced code element or code elements from the map, open the shortcut menu for the code element or the link. Choose **Go To Reference** and then the code element.  
  
## See Also  
 [Map dependencies across your solutions](../vs140/map-dependencies-across-your-solutions.md)   
 [Use code maps to debug your applications](../vs140/use-code-maps-to-debug-your-applications.md)   
 [Find potential problems using code map analyzers](../vs140/find-potential-problems-using-code-map-analyzers.md)   
 [Browse and rearrange code maps](../vs140/browse-and-rearrange-code-maps.md)   
 [Directed Graph Markup Language (DGML) reference](../vs140/directed-graph-markup-language--dgml--reference.md)