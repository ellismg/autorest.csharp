# AutoRest.CSharp.V3
> see https://aka.ms/autorest

## Configuration
```yaml
test-item: "cheese"
use-extension:
  "@autorest/modelerfour": "~4.0.20"

pipeline:
  modelerfour:
    input: openapi-document/multi-api/identity
  modelerfour/new-transform:
    input: modelerfour
  model-creator:
    input: modelerfour/new-transform
  model-creator/emitter:
    input: model-creator
    scope: output-scope

output-scope:
  output-artifact: source-file-csharp
```
