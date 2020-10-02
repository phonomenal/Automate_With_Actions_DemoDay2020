# Automate the SDLC with GitHub Actions
A public project that shows the power of using GitHub Actions to automate branch creation, creating changes to files, creating comments, assigning users, and deploying from labels.

# Getting Started
1. Create a GitHub Secret value for `AZURE_CREDS` with value for a generated Azure SDK Credentials file format JSON output from your Azure Subscription
2. Create a new issue, use the **Demo** issue template
3. Replace value in issue template with the Customer name (this string value will be updated in the Azure Web site)
4. GitHub Actions will kick off a job creating a new branch with the same name and create a comment in your issue
5. Create a Pull Request from the link in your comment
6. On the Pull Request, note the files changed
7. On the Pull Request, apply the labels for the different environments to kick off deployment (if you have the proper permissions):
   - `Deploy-to-DEV`
   - `Deploy-to-QA`
   - `Deploy-to-PROD`
8. The following GitHub Actions will kick off:
   - `Deployment on PR Label` 
   - `Deploy .NET Core Reading Time 3`
9. If a deployment is successful, the pull request will update the deployed environments section.
10. On the Pull request, remove the following labels to tear down the corresponding azure web apps:
   - `Azure-DEV-Live`
   - `Azure-QA-Live`
   - `Azure-PROD-Live`
  


