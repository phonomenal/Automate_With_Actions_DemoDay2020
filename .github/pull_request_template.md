### How To Deploy Azure Resource
- Deployment is driven by the use of labels:
   - `Deploy-to-DEV`
   - `Deploy-to-QA`
   - `Deploy-to-PROD`

### How to Teardown Azure resources
- Teardown is driven by the use of labels that are applied on successful deployments:
   - `Azure-DEV-Live `
   - `Azure-QA-Live`

- Teardown of the _entire_ resource group can also be manually triggered from the Actions tab!
