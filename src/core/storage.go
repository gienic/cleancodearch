package core

import (
	"domain"
	"interactor"
)

// Database connection here please :)
type (
	workflowRepo struct{}
)

func (wr *workflowRepo) Get(id int) *domain.Workflow {
	return &domain.Workflow{}
}

func (wr *workflowRepo) Update(flow domain.Workflow) {

}

func NewWorkflowRepo() interactor.DataRepo {
	return &workflowRepo{}
}
