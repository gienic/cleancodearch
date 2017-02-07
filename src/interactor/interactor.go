package interactor

import "domain"

type (
	Flow interface {
		Get(id int) *domain.Workflow
		Update(flow domain.Workflow)
	}

	flow struct {
		repo DataRepo
	}
)

func (f *flow) Get(id int) *domain.Workflow {
	flow := f.repo.Get(id)
	return flow
}

func (f *flow) Update(flow domain.Workflow) {

}

func NewFlow(repo DataRepo) Flow {
	return &flow{repo: repo}
}
