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
