# dotnet-cli-vary
Vary a string template with numeric range combinations

## Usage

`vary byint "Here is a string that counts [[1-3]] and [[6-9]]"`

### Output

```
Here is a string that counts 1 and 6
Here is a string that counts 1 and 7
Here is a string that counts 1 and 8
Here is a string that counts 1 and 9
Here is a string that counts 2 and 6
Here is a string that counts 2 and 7
Here is a string that counts 2 and 8
Here is a string that counts 2 and 9
Here is a string that counts 3 and 6
Here is a string that counts 3 and 7
Here is a string that counts 3 and 8
Here is a string that counts 3 and 9
```

### Why?

Sometimes you need to create strings by varying numeric values in the string to create all possible permutations containing the varying numbers.

## Real-ish World Example

`vary byint "INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES ([[1-3]],[[6-9]]);""`

```
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (1,6);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (1,7);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (1,8);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (1,9);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (2,6);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (2,7);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (2,8);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (2,9);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (3,6);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (3,7);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (3,8);
INSERT INTO CustomerProductType (CustomerType, ProductType) VALUES (3,9);


```

Your string templates can contain any number of variants. For example:

`vary byint "my string has many variants [[0-2]], [[1-4]], [[7-10]], [[2012-2018]]"`

```
my string has many variants 0, 1, 7, 2012
my string has many variants 0, 1, 7, 2013
my string has many variants 0, 1, 7, 2014
my string has many variants 0, 1, 7, 2015
my string has many variants 0, 1, 7, 2016
my string has many variants 0, 1, 7, 2017
my string has many variants 0, 1, 7, 2018
my string has many variants 0, 1, 8, 2012
my string has many variants 0, 1, 8, 2013
my string has many variants 0, 1, 8, 2014
my string has many variants 0, 1, 8, 2015
my string has many variants 0, 1, 8, 2016
my string has many variants 0, 1, 8, 2017
my string has many variants 0, 1, 8, 2018
my string has many variants 0, 1, 9, 2012
my string has many variants 0, 1, 9, 2013
my string has many variants 0, 1, 9, 2014
my string has many variants 0, 1, 9, 2015
my string has many variants 0, 1, 9, 2016
my string has many variants 0, 1, 9, 2017
my string has many variants 0, 1, 9, 2018
my string has many variants 0, 1, 10, 2012
my string has many variants 0, 1, 10, 2013
my string has many variants 0, 1, 10, 2014
my string has many variants 0, 1, 10, 2015
my string has many variants 0, 1, 10, 2016
my string has many variants 0, 1, 10, 2017
my string has many variants 0, 1, 10, 2018
my string has many variants 0, 2, 7, 2012
my string has many variants 0, 2, 7, 2013
my string has many variants 0, 2, 7, 2014
my string has many variants 0, 2, 7, 2015
my string has many variants 0, 2, 7, 2016
my string has many variants 0, 2, 7, 2017
my string has many variants 0, 2, 7, 2018
my string has many variants 0, 2, 8, 2012
my string has many variants 0, 2, 8, 2013
my string has many variants 0, 2, 8, 2014
my string has many variants 0, 2, 8, 2015
my string has many variants 0, 2, 8, 2016
my string has many variants 0, 2, 8, 2017
my string has many variants 0, 2, 8, 2018
my string has many variants 0, 2, 9, 2012
my string has many variants 0, 2, 9, 2013
my string has many variants 0, 2, 9, 2014
my string has many variants 0, 2, 9, 2015
my string has many variants 0, 2, 9, 2016
my string has many variants 0, 2, 9, 2017
my string has many variants 0, 2, 9, 2018
my string has many variants 0, 2, 10, 2012
my string has many variants 0, 2, 10, 2013
my string has many variants 0, 2, 10, 2014
my string has many variants 0, 2, 10, 2015
my string has many variants 0, 2, 10, 2016
my string has many variants 0, 2, 10, 2017
my string has many variants 0, 2, 10, 2018
my string has many variants 0, 3, 7, 2012
my string has many variants 0, 3, 7, 2013
my string has many variants 0, 3, 7, 2014
my string has many variants 0, 3, 7, 2015
my string has many variants 0, 3, 7, 2016
my string has many variants 0, 3, 7, 2017
my string has many variants 0, 3, 7, 2018
my string has many variants 0, 3, 8, 2012
my string has many variants 0, 3, 8, 2013
my string has many variants 0, 3, 8, 2014
my string has many variants 0, 3, 8, 2015
my string has many variants 0, 3, 8, 2016
my string has many variants 0, 3, 8, 2017
my string has many variants 0, 3, 8, 2018
my string has many variants 0, 3, 9, 2012
my string has many variants 0, 3, 9, 2013
my string has many variants 0, 3, 9, 2014
my string has many variants 0, 3, 9, 2015
my string has many variants 0, 3, 9, 2016
my string has many variants 0, 3, 9, 2017
my string has many variants 0, 3, 9, 2018
my string has many variants 0, 3, 10, 2012
my string has many variants 0, 3, 10, 2013
my string has many variants 0, 3, 10, 2014
my string has many variants 0, 3, 10, 2015
my string has many variants 0, 3, 10, 2016
my string has many variants 0, 3, 10, 2017
my string has many variants 0, 3, 10, 2018
my string has many variants 0, 4, 7, 2012
my string has many variants 0, 4, 7, 2013
my string has many variants 0, 4, 7, 2014
my string has many variants 0, 4, 7, 2015
my string has many variants 0, 4, 7, 2016
my string has many variants 0, 4, 7, 2017
my string has many variants 0, 4, 7, 2018
my string has many variants 0, 4, 8, 2012
my string has many variants 0, 4, 8, 2013
my string has many variants 0, 4, 8, 2014
my string has many variants 0, 4, 8, 2015
my string has many variants 0, 4, 8, 2016
my string has many variants 0, 4, 8, 2017
my string has many variants 0, 4, 8, 2018
my string has many variants 0, 4, 9, 2012
my string has many variants 0, 4, 9, 2013
my string has many variants 0, 4, 9, 2014
my string has many variants 0, 4, 9, 2015
my string has many variants 0, 4, 9, 2016
my string has many variants 0, 4, 9, 2017
my string has many variants 0, 4, 9, 2018
my string has many variants 0, 4, 10, 2012
my string has many variants 0, 4, 10, 2013
my string has many variants 0, 4, 10, 2014
my string has many variants 0, 4, 10, 2015
my string has many variants 0, 4, 10, 2016
my string has many variants 0, 4, 10, 2017
my string has many variants 0, 4, 10, 2018
my string has many variants 1, 1, 7, 2012
my string has many variants 1, 1, 7, 2013
my string has many variants 1, 1, 7, 2014
my string has many variants 1, 1, 7, 2015
my string has many variants 1, 1, 7, 2016
my string has many variants 1, 1, 7, 2017
my string has many variants 1, 1, 7, 2018
my string has many variants 1, 1, 8, 2012
my string has many variants 1, 1, 8, 2013
my string has many variants 1, 1, 8, 2014
my string has many variants 1, 1, 8, 2015
my string has many variants 1, 1, 8, 2016
my string has many variants 1, 1, 8, 2017
my string has many variants 1, 1, 8, 2018
my string has many variants 1, 1, 9, 2012
my string has many variants 1, 1, 9, 2013
my string has many variants 1, 1, 9, 2014
my string has many variants 1, 1, 9, 2015
my string has many variants 1, 1, 9, 2016
my string has many variants 1, 1, 9, 2017
my string has many variants 1, 1, 9, 2018
my string has many variants 1, 1, 10, 2012
my string has many variants 1, 1, 10, 2013
my string has many variants 1, 1, 10, 2014
my string has many variants 1, 1, 10, 2015
my string has many variants 1, 1, 10, 2016
my string has many variants 1, 1, 10, 2017
my string has many variants 1, 1, 10, 2018
my string has many variants 1, 2, 7, 2012
my string has many variants 1, 2, 7, 2013
my string has many variants 1, 2, 7, 2014
my string has many variants 1, 2, 7, 2015
my string has many variants 1, 2, 7, 2016
my string has many variants 1, 2, 7, 2017
my string has many variants 1, 2, 7, 2018
my string has many variants 1, 2, 8, 2012
my string has many variants 1, 2, 8, 2013
my string has many variants 1, 2, 8, 2014
my string has many variants 1, 2, 8, 2015
my string has many variants 1, 2, 8, 2016
my string has many variants 1, 2, 8, 2017
my string has many variants 1, 2, 8, 2018
my string has many variants 1, 2, 9, 2012
my string has many variants 1, 2, 9, 2013
my string has many variants 1, 2, 9, 2014
my string has many variants 1, 2, 9, 2015
my string has many variants 1, 2, 9, 2016
my string has many variants 1, 2, 9, 2017
my string has many variants 1, 2, 9, 2018
my string has many variants 1, 2, 10, 2012
my string has many variants 1, 2, 10, 2013
my string has many variants 1, 2, 10, 2014
my string has many variants 1, 2, 10, 2015
my string has many variants 1, 2, 10, 2016
my string has many variants 1, 2, 10, 2017
my string has many variants 1, 2, 10, 2018
my string has many variants 1, 3, 7, 2012
my string has many variants 1, 3, 7, 2013
my string has many variants 1, 3, 7, 2014
my string has many variants 1, 3, 7, 2015
my string has many variants 1, 3, 7, 2016
my string has many variants 1, 3, 7, 2017
my string has many variants 1, 3, 7, 2018
my string has many variants 1, 3, 8, 2012
my string has many variants 1, 3, 8, 2013
my string has many variants 1, 3, 8, 2014
my string has many variants 1, 3, 8, 2015
my string has many variants 1, 3, 8, 2016
my string has many variants 1, 3, 8, 2017
my string has many variants 1, 3, 8, 2018
my string has many variants 1, 3, 9, 2012
my string has many variants 1, 3, 9, 2013
my string has many variants 1, 3, 9, 2014
my string has many variants 1, 3, 9, 2015
my string has many variants 1, 3, 9, 2016
my string has many variants 1, 3, 9, 2017
my string has many variants 1, 3, 9, 2018
my string has many variants 1, 3, 10, 2012
my string has many variants 1, 3, 10, 2013
my string has many variants 1, 3, 10, 2014
my string has many variants 1, 3, 10, 2015
my string has many variants 1, 3, 10, 2016
my string has many variants 1, 3, 10, 2017
my string has many variants 1, 3, 10, 2018
my string has many variants 1, 4, 7, 2012
my string has many variants 1, 4, 7, 2013
my string has many variants 1, 4, 7, 2014
my string has many variants 1, 4, 7, 2015
my string has many variants 1, 4, 7, 2016
my string has many variants 1, 4, 7, 2017
my string has many variants 1, 4, 7, 2018
my string has many variants 1, 4, 8, 2012
my string has many variants 1, 4, 8, 2013
my string has many variants 1, 4, 8, 2014
my string has many variants 1, 4, 8, 2015
my string has many variants 1, 4, 8, 2016
my string has many variants 1, 4, 8, 2017
my string has many variants 1, 4, 8, 2018
my string has many variants 1, 4, 9, 2012
my string has many variants 1, 4, 9, 2013
my string has many variants 1, 4, 9, 2014
my string has many variants 1, 4, 9, 2015
my string has many variants 1, 4, 9, 2016
my string has many variants 1, 4, 9, 2017
my string has many variants 1, 4, 9, 2018
my string has many variants 1, 4, 10, 2012
my string has many variants 1, 4, 10, 2013
my string has many variants 1, 4, 10, 2014
my string has many variants 1, 4, 10, 2015
my string has many variants 1, 4, 10, 2016
my string has many variants 1, 4, 10, 2017
my string has many variants 1, 4, 10, 2018
my string has many variants 2, 1, 7, 2012
my string has many variants 2, 1, 7, 2013
my string has many variants 2, 1, 7, 2014
my string has many variants 2, 1, 7, 2015
my string has many variants 2, 1, 7, 2016
my string has many variants 2, 1, 7, 2017
my string has many variants 2, 1, 7, 2018
my string has many variants 2, 1, 8, 2012
my string has many variants 2, 1, 8, 2013
my string has many variants 2, 1, 8, 2014
my string has many variants 2, 1, 8, 2015
my string has many variants 2, 1, 8, 2016
my string has many variants 2, 1, 8, 2017
my string has many variants 2, 1, 8, 2018
my string has many variants 2, 1, 9, 2012
my string has many variants 2, 1, 9, 2013
my string has many variants 2, 1, 9, 2014
my string has many variants 2, 1, 9, 2015
my string has many variants 2, 1, 9, 2016
my string has many variants 2, 1, 9, 2017
my string has many variants 2, 1, 9, 2018
my string has many variants 2, 1, 10, 2012
my string has many variants 2, 1, 10, 2013
my string has many variants 2, 1, 10, 2014
my string has many variants 2, 1, 10, 2015
my string has many variants 2, 1, 10, 2016
my string has many variants 2, 1, 10, 2017
my string has many variants 2, 1, 10, 2018
my string has many variants 2, 2, 7, 2012
my string has many variants 2, 2, 7, 2013
my string has many variants 2, 2, 7, 2014
my string has many variants 2, 2, 7, 2015
my string has many variants 2, 2, 7, 2016
my string has many variants 2, 2, 7, 2017
my string has many variants 2, 2, 7, 2018
my string has many variants 2, 2, 8, 2012
my string has many variants 2, 2, 8, 2013
my string has many variants 2, 2, 8, 2014
my string has many variants 2, 2, 8, 2015
my string has many variants 2, 2, 8, 2016
my string has many variants 2, 2, 8, 2017
my string has many variants 2, 2, 8, 2018
my string has many variants 2, 2, 9, 2012
my string has many variants 2, 2, 9, 2013
my string has many variants 2, 2, 9, 2014
my string has many variants 2, 2, 9, 2015
my string has many variants 2, 2, 9, 2016
my string has many variants 2, 2, 9, 2017
my string has many variants 2, 2, 9, 2018
my string has many variants 2, 2, 10, 2012
my string has many variants 2, 2, 10, 2013
my string has many variants 2, 2, 10, 2014
my string has many variants 2, 2, 10, 2015
my string has many variants 2, 2, 10, 2016
my string has many variants 2, 2, 10, 2017
my string has many variants 2, 2, 10, 2018
my string has many variants 2, 3, 7, 2012
my string has many variants 2, 3, 7, 2013
my string has many variants 2, 3, 7, 2014
my string has many variants 2, 3, 7, 2015
my string has many variants 2, 3, 7, 2016
my string has many variants 2, 3, 7, 2017
my string has many variants 2, 3, 7, 2018
my string has many variants 2, 3, 8, 2012
my string has many variants 2, 3, 8, 2013
my string has many variants 2, 3, 8, 2014
my string has many variants 2, 3, 8, 2015
my string has many variants 2, 3, 8, 2016
my string has many variants 2, 3, 8, 2017
my string has many variants 2, 3, 8, 2018
my string has many variants 2, 3, 9, 2012
my string has many variants 2, 3, 9, 2013
my string has many variants 2, 3, 9, 2014
my string has many variants 2, 3, 9, 2015
my string has many variants 2, 3, 9, 2016
my string has many variants 2, 3, 9, 2017
my string has many variants 2, 3, 9, 2018
my string has many variants 2, 3, 10, 2012
my string has many variants 2, 3, 10, 2013
my string has many variants 2, 3, 10, 2014
my string has many variants 2, 3, 10, 2015
my string has many variants 2, 3, 10, 2016
my string has many variants 2, 3, 10, 2017
my string has many variants 2, 3, 10, 2018
my string has many variants 2, 4, 7, 2012
my string has many variants 2, 4, 7, 2013
my string has many variants 2, 4, 7, 2014
my string has many variants 2, 4, 7, 2015
my string has many variants 2, 4, 7, 2016
my string has many variants 2, 4, 7, 2017
my string has many variants 2, 4, 7, 2018
my string has many variants 2, 4, 8, 2012
my string has many variants 2, 4, 8, 2013
my string has many variants 2, 4, 8, 2014
my string has many variants 2, 4, 8, 2015
my string has many variants 2, 4, 8, 2016
my string has many variants 2, 4, 8, 2017
my string has many variants 2, 4, 8, 2018
my string has many variants 2, 4, 9, 2012
my string has many variants 2, 4, 9, 2013
my string has many variants 2, 4, 9, 2014
my string has many variants 2, 4, 9, 2015
my string has many variants 2, 4, 9, 2016
my string has many variants 2, 4, 9, 2017
my string has many variants 2, 4, 9, 2018
my string has many variants 2, 4, 10, 2012
my string has many variants 2, 4, 10, 2013
my string has many variants 2, 4, 10, 2014
my string has many variants 2, 4, 10, 2015
my string has many variants 2, 4, 10, 2016
my string has many variants 2, 4, 10, 2017
my string has many variants 2, 4, 10, 2018
```
