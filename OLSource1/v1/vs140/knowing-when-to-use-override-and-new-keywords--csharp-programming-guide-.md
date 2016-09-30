---
title: "Knowing When to Use Override and New Keywords (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "override keyword [C#]"
  - "new keyword [C#]"
  - "polymorphism [C#], using override and new [C#]"
ms.assetid: 323db184-b136-46fc-8839-007886e7e8b0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Knowing When to Use Override and New Keywords (C# Programming Guide)
In C#, a method in a derived class can have the same name as a method in the base class. You can specify how the methods interact by using the [new](../vs140/new--csharp-reference-.md) and [override](../vs140/override--csharp-reference-.md) keywords. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> modifier *extends* the base class method, and the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> modifier *hides* it. The difference is illustrated in the examples in this topic.  
  
 In a console application, declare the following two classes, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method, declare variables <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and its value is of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and its value is of type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and its value is of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. This is the variable to pay attention to.  
  
 Because <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> have type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, they can only directly access <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, unless you use casting. Variable <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> can access both <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. These relationships are shown in the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Next, add the following <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The signature of this method matches the signature of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Because <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> now has a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method, a second calling statement can be added for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> variables <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, as shown in the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When you build the project, you see that the addition of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> causes a warning. The warning says that the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method in <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> hides the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method in <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. You are advised to use the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> keyword in the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> definition if you intend to cause that result. Alternatively, you could rename one of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> methods to resolve the warning, but that is not always practical.  
  
 Before adding <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, run the program to see the output produced by the additional calling statements. The following results are displayed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> keyword preserves the relationships that produce that output, but it suppresses the warning. The variables that have type <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> continue to access the members of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and the variable that has type <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> continues to access members in <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> first, and then to consider members inherited from <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 To suppress the warning, add the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> modifier to the definition of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, as shown in the following code. The modifier can be added before or after <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Run the program again to verify that the output has not changed. Also verify that the warning no longer appears. By using <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, you are asserting that you are aware that the member that it modifies hides a member that is inherited from the base class. For more information about name hiding through inheritance, see [new Modifier (C# Reference)](../vs140/new-modifier--csharp-reference-.md).  
  
 To contrast this behavior to the effects of using <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, add the following method to <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> modifier can be added before or after <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Add the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> modifier to the definition of <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> modifier can be added before or after <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Run the project again. Notice especially the last two lines of the following output.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The use of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> modifier enables <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to access the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> method that is defined in <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. Typically, that is the desired behavior in inheritance hierarchies. You want objects that have values that are created from the derived class to use the methods that are defined in the derived class. You achieve that behavior by using <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to extend the base class method.  
  
 The following code contains the full example.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The following example illustrates similar behavior in a different context. The example defines three classes: a base class named <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and two classes that are derived from it, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. The base class contains a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> method. The method displays a basic description of a car, and then calls <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to provide additional information. Each of the three classes defines a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> modifier is used to define <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> modifier is used to define <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The example tests which version of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is called. The following method, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, declares an instance of each class, and then calls <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> on each instance.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> produces the following output. Notice especially the results for <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, which probably are not what you expected. The type of the object is <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, but <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> does not access the version of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> that is defined in the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> class because that method is declared with the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> modifier, not the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> modifier. As a result, a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object displays the same description as a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object. Contrast the results for <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, which is a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object. In this case, the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> method that is declared in the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> class overrides the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> method that is declared in the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> class, and the description that is displayed describes a minivan.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> creates a list of objects that have type <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>. The values of the objects are instantiated from the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> classes. <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> is called on each element of the list. The following code shows the definition of <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The following output is displayed. Notice that it is the same as the output that is displayed by <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> class is not called, regardless of whether the type of the object is <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, as in <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, as in <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>. Conversely, <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> method from the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> class in both cases, whether it has type <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> or type <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Methods <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> complete the example. These methods call <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> directly, first from objects declared to have type <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>), then from objects declared to have type <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>). The following code defines these two methods.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The methods produce the following output, which corresponds to the results from the first example in this topic.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The following code shows the complete project and its output.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Versioning with the Override and New Keywords (C#)](../vs140/versioning-with-the-override-and-new-keywords--csharp-programming-guide-.md)   
 [base (C# Reference)](../vs140/base--csharp-reference-.md)   
 [abstract (C# Reference)](../vs140/abstract--csharp-reference-.md)