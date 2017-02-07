package main

import (
	"core"
	"fmt"
	"interactor"
)

func main() {

	repo := core.NewWorkflowRepo()
	i := interactor.NewFlow(repo)
	fmt.Println(i.Get(1))
}
