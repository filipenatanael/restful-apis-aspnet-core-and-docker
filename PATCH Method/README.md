# Working With The Verb PATCH

**PersonsController.cs**
```C#
        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(List<PersonVO>), 202)]
        [ProducesResponseType(202)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Patch(int id, [FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            var updatePerson = this.personService.Update(person);
            if (updatePerson == null) return BadRequest();
            return new ObjectResult(updatePerson);
        }
```

[PUT vs PATCH](https://stackoverflow.com/questions/28459418/rest-api-put-vs-patch-with-real-life-examples)
[HATEOAS ](https://pt.stackoverflow.com/questions/49492/por-que-hateoas-%C3%A9-importante)
[Hardcoding](https://pt.wikipedia.org/wiki/Codifica%C3%A7%C3%A3o_r%C3%ADgida)
[Versioning via the URL Path](https://github.com/Microsoft/aspnet-api-versioning/wiki/Versioning-via-the-URL-Path)
[API Versioning Options](https://github.com/Microsoft/aspnet-api-versioning/wiki/API-Versioning-Options)
[Introduction to API Versioning Best Practices](https://nordicapis.com/introduction-to-api-versioning-best-practices)
[RESTful API Designing guidelines - The best practices](https://hackernoon.com/restful-api-designing-guidelines-the-best-practices-60e1d954e7c9)
[LINQ - Lambda Expressions](https://www.youtube.com/watch?v=3EEP9JxqLpE)
[Exception InnerException](https://docs.microsoft.com/pt-br/dotnet/api/system.exception.innerexception?view=netframework-4.7.2)

[Postman Endpoits](/RESTfulAPIDesign/Postman)
