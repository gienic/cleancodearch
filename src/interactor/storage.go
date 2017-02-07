package interactor

import "domain"

type (
	DataRepo interface {
		Get(id int) *domain.Workflow
		Update(flow domain.Workflow)
	}
)
