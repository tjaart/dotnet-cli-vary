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
